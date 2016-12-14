using NUnit.Framework;
using System;

namespace lab4_v2
{
	[TestFixture ()]
	public class TestApp
	{
		/**********************************************************************************/

		private Application GetAppInstance() {
			return new Application ("Test name", "Unknown");
		}

		[Test ()]
		public void TestAppInit ()
		{
			Application app = new Application ("Test name", "Unknown");

			Assert.AreEqual ("Test name", app.Name);
			Assert.AreEqual ("Unknown", app.Producer);
		}

		/**********************************************************************************/

		[Test ()]
		public void TestNameChange ()
		{
			Application app = GetAppInstance();

			string target_name = "some name";

			app.Name = target_name;
			Assert.AreEqual (target_name, app.Name);
		}

		/**********************************************************************************/

		[Test()]
		public void TestEmptyNameChange()
		{
			Application app = GetAppInstance();

			Assert.That ( () => {
				app.Name = "";
			},
				Throws.ArgumentException
			);
		}

		/**********************************************************************************/

		[Test()]
		public void TestEmptyProducerNameChange()
		{
			Application app = GetAppInstance();

			Assert.That ( () => {
				app.Producer = "";
			},
				Throws.ArgumentException
			);
		}

		/**********************************************************************************/

		[Test()]
		public void TestChangeNegativeFreq()
		{
			Application app = GetAppInstance();

			Assert.That ( () => {
				app.MinCpuFreq = -1;
			},
				Throws.TypeOf<ArgumentOutOfRangeException>()
			);
		}

		/**********************************************************************************/

		[Test()]
		public void TestChangeNegativeRam()
		{
			Application app = GetAppInstance();

			Assert.That ( () => {
				app.MinRamCapacity = -1;
			},
				Throws.TypeOf<ArgumentOutOfRangeException>()
			);
		}

		/**********************************************************************************/

		[Test()]
		public void TestChangeGpuMem()
		{
			Application app = GetAppInstance();

			Assert.That ( () => {
				app.MinGpuMem = -1;
			},
				Throws.TypeOf<ArgumentOutOfRangeException>()
			);
		}

		/**********************************************************************************/

		[Test()]
		public void CheckOnVersionChanged()
		{
			Application app = GetAppInstance();

			bool is_called = false;
			Version new_version = new Version(2, 0);

			app.VersionChanged += (o, e) => {
				is_called = true;

				Assert.IsInstanceOf(typeof(Application), o);
				Assert.AreEqual(new_version, e.NewVersion);
			};

			app.AppVersion = new_version;

			Assert.AreEqual (true, is_called);
		}

		/**********************************************************************************/

		[Test()]
		public void CheckOnNameChanged()
		{
			Application app = GetAppInstance();

			bool is_called = false;
			string new_name = "new name";

			app.NameChanged += (object o, NewNameEventArgs e) => {
				is_called = true;

				Assert.IsInstanceOf(typeof(Application), o);
				Assert.AreEqual(new_name, e.NewName);
			};

			app.Name = new_name;

			Assert.AreEqual (true, is_called);
		}

		/**********************************************************************************/

		[Test()]
		public void TestUpdate()
		{
			Application app = GetAppInstance();

			double start_freq = 1;
			double start_min_gpu_mem = 1024;
			double start_min_ram = 512;
			Version start_version = new Version(1, 0);

			app.MinCpuFreq = start_freq;
			app.MinGpuMem = start_min_gpu_mem;
			app.MinRamCapacity = start_min_ram;
			app.AppVersion = start_version;

			app.Update ();

			Assert.IsTrue (app.MinCpuFreq > start_freq);
			Assert.IsTrue (app.MinGpuMem > start_min_gpu_mem);
			Assert.IsTrue (app.MinRamCapacity > start_min_ram);
			Assert.IsTrue (app.AppVersion > start_version);
		}

		/**********************************************************************************/

	}
}

