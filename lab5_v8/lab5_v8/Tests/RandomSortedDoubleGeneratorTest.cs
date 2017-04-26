using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace lab5_v8
{
	[TestFixture ()]
	public class RandomSortedDoubleGeneratorTest
	{
		[Test ()]
		public void TestGeneratedArrayIsSorted ()
		{
			const double min_value = 0;
			double old_item = min_value;

			IEnumerable<double> generator = (RandomOrderedDoubles.Generator(min_value, 100, 1000));

			foreach (double item in generator) {
				Assert.Greater (item, old_item);
			}
		}
	}
}

