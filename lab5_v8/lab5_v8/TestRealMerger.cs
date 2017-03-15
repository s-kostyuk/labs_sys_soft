using NUnit.Framework;
using System;

namespace lab5_v8
{
	[TestFixture ()]
	public class TestRealMerger
	{
		[Test ()]
		public void TestMerge ()
		{
			double[] test_array1 = { -1, 2, 3, 6, 7, 8, 9, 10, 66, 88, 89};
			double[] test_array2 = { -22, 2, 11, 23, 78, 90 };

			double[] exp_result = { -22, -1, 2, 2, 3, 6, 7, 8, 9, 10, 11, 23, 66, 78, 88, 89, 90};

			double[] result = new double[exp_result.Length];
			int result_index = 0;

			RealMerger merger = new RealMerger ();
			merger.SetWriter ((double new_value) => {
				result [result_index++] = new_value;
			}
			);

			merger.Merge (ref test_array1, ref test_array2);

			Assert.AreEqual (exp_result, result);
		}
	}
}

