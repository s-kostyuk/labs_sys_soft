using NUnit.Framework;
using System;

namespace lab4_v2
{
	[TestFixture ()]
	public class TestComputerInfo
	{
		private ComputerInfo GetInfoInstance() {
			return new ComputerInfo ();
		}

		/**********************************************************************************/

		[Test ()]
		public void TestInit ()
		{
		}

		/**********************************************************************************/

		[Test()]
		public void TestChangeNegativeFreq()
		{
			ComputerInfo info = GetInfoInstance();

			Assert.That ( () => {
				info.CpuFreq = -1;
			},
				Throws.TypeOf<ArgumentOutOfRangeException>()
			);
		}

		/**********************************************************************************/

		[Test()]
		public void TestChangeNegativeRam()
		{
			ComputerInfo info = GetInfoInstance();

			Assert.That ( () => {
				info.RamCapacity = -1;
			},
				Throws.TypeOf<ArgumentOutOfRangeException>()
			);
		}

		/**********************************************************************************/

		[Test()]
		public void TestChangeGpuMem()
		{
			ComputerInfo info = GetInfoInstance();

			Assert.That ( () => {
				info.GpuMem = -1;
			},
				Throws.TypeOf<ArgumentOutOfRangeException>()
			);
		}

		/**********************************************************************************/
	}
}

