using NUnit.Framework;
using System;

namespace lab5_v8
{
	[TestFixture ()]
	public class TestRealArrayEnumerator
	{
//		[Test ()]
//		public void TestNextNeeded ()
//		{
//			double[] test_array = { 1, 2, 3, 4, 5, 6, 7 };
//
//			RealArrayEnumerator enumer = new RealArrayEnumerator (test_array);
//
//			Assert.That (() => {
//				return enumer.item();
//			},
//				Throws.InvalidOperationException,
//				"You must to call next() method at least once"
//			);
//		}

		[Test ()]
		public void TestCase ()
		{
			double[] test_array = { 1, 2, 3, 4, 5, 6, 7 };

			RealArrayEnumerator enumer = new RealArrayEnumerator (test_array);

			foreach (double element in test_array) {
				double te = enumer.next ();

				Assert.AreEqual (element, te);

			}
				
		}
	}
}

