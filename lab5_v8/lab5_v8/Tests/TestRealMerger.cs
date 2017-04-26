using NUnit.Framework;
using System.Collections.Generic;

namespace lab5_v8
{
	[TestFixture ()]
	public class TestRealMerger
	{
		[Test ()]
		public void TestMerge ()
		{
			List<double> test_array1 = new List<double>{ -1, 2, 3, 6, 7, 8, 9, 10, 66, 88, 89};
			List<double> test_array2 = new List<double>{ -22, 2, 11, 23, 78, 90 };

			List<double> exp_result = new List<double>{ -22, -1, 2, 2, 3, 6, 7, 8, 9, 10, 11, 23, 66, 78, 88, 89, 90};

			List<double> result = new List<double>();

			SortedMerger merger = new SortedMerger ();
			merger.SetWriter ((object new_value) => {
				result.Add((double)new_value);
			}
			);

			merger.Merge (test_array1.GetEnumerator(), test_array2.GetEnumerator());

			Assert.AreEqual (exp_result, result);
		}
	}
}

