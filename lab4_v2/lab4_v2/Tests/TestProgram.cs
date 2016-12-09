using NUnit.Framework;
using System;

namespace lab4_v2
{
	[TestFixture ()]
	public class TestProgram
	{
		/**********************************************************************************/

		[Test ()]
		public void TestProgramInit ()
		{
		}

		/**********************************************************************************/

		[Test ()]
		public void TestNameChange ()
		{
			Program p = new Program ();

			string target_name = "some name";

			p.name = target_name;
			Assert.AreEqual (target_name, p.name);
		}

		/**********************************************************************************/

		[Test()]
		public void TestEmptyNameChange()
		{
			Program p = new Program ();

			Assert.That ( () => {
				p.name = "";
			},
				Throws.ArgumentException
			);
		}

		/**********************************************************************************/

		[Test()]
		public void TestChangeNegativeFreq()
		{
			Program p = new Program ();

			Assert.That ( () => {
				p.min_cpu_freq = -1;
			},
				Throws.TypeOf<ArgumentOutOfRangeException>()
			);
		}

		/**********************************************************************************/

		[Test()]
		public void TestChangeNegativeRam()
		{
			Program p = new Program ();

			Assert.That ( () => {
				p.min_ram = -1;
			},
				Throws.TypeOf<ArgumentOutOfRangeException>()
			);
		}

		/**********************************************************************************/

		[Test()]
		public void TestChangeGpuMem()
		{
			Program p = new Program ();

			Assert.That ( () => {
				p.min_gpu_mem = -1;
			},
				Throws.TypeOf<ArgumentOutOfRangeException>()
			);
		}

		/**********************************************************************************/

		[Test()]
		public void TestChangeNegativeVersion()
		{
			Program p = new Program ();

			Assert.That ( () => {
				p.version = -1;
			},
				Throws.TypeOf<ArgumentOutOfRangeException>()
			);
		}

		/**********************************************************************************/

		[Test()]
		public void CheckOnVersionChanged()
		{
			Program p = new Program ();

			bool is_called = false;
			double new_version = 1.0;

			p.VersionChanged += (o, e) => { 
				is_called = true;

				Assert.IsInstanceOf(typeof(Program), o);
				Assert.AreEqual(new_version, e.NewVersion);
			};

			p.version = 1.0;

			Assert.AreEqual (true, is_called);
		}

		/**********************************************************************************/

		[Test()]
		public void CheckOnNameChanged()
		{
			Program p = new Program ();

			bool is_called = false;
			string new_name = "new name";

			p.NameChanged += (object o, NewNameEventArgs e) => {
				is_called = true;

				Assert.IsInstanceOf(typeof(Program), o);
				Assert.AreEqual(new_name, e.NewName);
			};

			p.name = new_name;

			Assert.AreEqual (true, is_called);
		}

		/**********************************************************************************/

		[Test()]
		public void TestUpdate()
		{
			Program p = new Program();

			double start_freq = 1;
			double start_min_gpu_mem = 1024;
			double start_min_ram = 512;
			double start_version = 1.0;

			p.min_cpu_freq = start_freq;
			p.min_gpu_mem = start_min_gpu_mem;
			p.min_ram = start_min_ram;
			p.version = start_version;

			p.Update ();

			Assert.IsTrue (p.min_cpu_freq > start_freq);
			Assert.IsTrue (p.min_gpu_mem > start_min_gpu_mem);
			Assert.IsTrue (p.min_ram > start_min_ram);
			Assert.IsTrue (p.version > start_version);
		}

		/**********************************************************************************/

	}
}

