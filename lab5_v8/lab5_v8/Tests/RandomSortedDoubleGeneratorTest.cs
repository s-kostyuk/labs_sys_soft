using NUnit.Framework;
using System;

namespace lab5_v8
{
	[TestFixture ()]
	public class RandomSortedDoubleGeneratorTest
	{
		[Test ()]
		public void TestGeneratedArrayIsSorted ()
		{
			RandomSortedDoubleGenerator generator = new RandomSortedDoubleGenerator();

			const double min_value = 0;
			double old_item = min_value;

			double[] generated = generator.Generate(min_value, 100, 1000);

			foreach (double item in generated) {
				Assert.Greater (item, old_item);
			}
		}
	}
}

