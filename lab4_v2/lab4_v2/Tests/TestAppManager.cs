using NUnit.Framework;
using System;

namespace lab4_v2
{
	[TestFixture ()]
	public class TestAppManager
	{
		/**********************************************************************************/

		[Test ()]
		public void TestDefaultConstructor ()
		{
			AppManager am = new AppManager ();

			Assert.AreEqual (new ComputerInfo (), am.ComputerInfo);
		}

		/**********************************************************************************/

		[Test ()]
		public void TestConstructor ()
		{
			ComputerInfo ci = new ComputerInfo ();
			ci.CpuFreq = 1000;
			ci.RamCapacity = 1000;
			ci.GpuMem = 500;
			ci.OSType = "linux";

			AppManager am = new AppManager (ci);

			Assert.AreEqual (ci, am.ComputerInfo);
		}

		/**********************************************************************************/
	}
}

