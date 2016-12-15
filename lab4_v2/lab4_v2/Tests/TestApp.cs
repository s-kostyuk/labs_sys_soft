﻿using NUnit.Framework;
using System;

namespace lab4_v2
{
	[TestFixture ()]
	public class TestApp
	{
		/**********************************************************************************/

		private Application GetAppInstance ()
		{
			return new Application ("Test name", "Unknown");
		}

		[Test ()]
		public void TestAppInit ()
		{
			string app_name = "Test name";
			string app_producer = "Unknown";

			Application app = new Application (app_name, app_producer);

			Assert.AreEqual (app_name, app.Name);
			Assert.AreEqual (app_producer, app.Producer);
			Assert.AreEqual (
				String.Format ("{0}.{1}", app_producer, app_name),
				app.ID
			);
		}

		/**********************************************************************************/

		[Test ()]
		public void TestNameChange ()
		{
			Application app = GetAppInstance ();

			string target_name = "some name";

			app.Name = target_name;
			Assert.AreEqual (target_name, app.Name);
		}

		/**********************************************************************************/

		[Test ()]
		public void TestEmptyNameChange ()
		{
			Application app = GetAppInstance ();

			Assert.That (() => {
				app.Name = "";
			},
				Throws.ArgumentException
			);
		}

		/**********************************************************************************/

		[Test ()]
		public void TestEmptyProducerNameChange ()
		{
			Application app = GetAppInstance ();

			Assert.That (() => {
				app.Producer = "";
			},
				Throws.ArgumentException
			);
		}

		/**********************************************************************************/

		[Test ()]
		public void CheckOnVersionChanged ()
		{
			Application app = GetAppInstance ();

			bool is_called = false;
			Version new_version = new Version (2, 0);

			app.VersionChanged += (o, e) => {
				is_called = true;

				Assert.IsInstanceOf (typeof(Application), o);
				Assert.AreEqual (new_version, e.NewVersion);
			};

			app.AppVersion = new_version;

			Assert.AreEqual (true, is_called);
		}

		/**********************************************************************************/

		[Test ()]
		public void CheckOnNameChanged ()
		{
			Application app = GetAppInstance ();

			bool is_called = false;
			string new_name = "new name";

			app.NameChanged += (object o, NewNameEventArgs e) => {
				is_called = true;

				Assert.IsInstanceOf (typeof(Application), o);
				Assert.AreEqual (new_name, e.NewName);
			};

			app.Name = new_name;

			Assert.AreEqual (true, is_called);
		}

		/**********************************************************************************/

		[Test ()]
		public void TestUpdate ()
		{
			Application app = GetAppInstance ();

			Version start_version = new Version (1, 0);

			ComputerInfo start_req = new ComputerInfo ();
			start_req.CpuFreq = 1;
			start_req.GpuMem = 512;
			start_req.RamCapacity = 1024;

			app.MinRequirements = start_req;
			app.AppVersion = start_version;

			app.Update ();

			Assert.IsTrue (app.MinRequirements.CpuFreq > start_req.CpuFreq);
			Assert.IsTrue (app.MinRequirements.GpuMem > start_req.GpuMem);
			Assert.IsTrue (app.MinRequirements.RamCapacity > start_req.RamCapacity);
			Assert.IsTrue (app.AppVersion > start_version);
		}

		/**********************************************************************************/

		[Test ()]
		public void TestOnVersionChangedInUpdate ()
		{
			Application app = GetAppInstance ();

			bool is_called = false;

			app.VersionChanged += (o, e) => {
				is_called = true;

				Assert.IsInstanceOf (typeof(Application), o);
			};

			app.Update ();

			Assert.AreEqual (true, is_called);
		}


		/**********************************************************************************/

		[Test ()]
		public void TestIdIsStill ()
		{
			string app_name = "Hello, world!";
			string app_producer = "Producer";

			Application a1 = new Application (app_name, app_producer);

			string old_id = a1.ID;

			a1.Name = "new name";
			a1.Producer = "new producer";

			Assert.AreEqual (old_id, a1.ID);
		}

		/**********************************************************************************/

		[Test ()]
		public void TestAreEqual ()
		{
			string app_name = "Hello, world!";
			string app_producer = "Producer";

			Application a1 = new Application (app_name, app_producer);
			Application a2 = new Application (app_name, app_producer);

			a1.Name = "new name";
			a2.Producer = "new producer";

			Assert.AreEqual (a1, a2);
		}

		/**********************************************************************************/

	}
}

