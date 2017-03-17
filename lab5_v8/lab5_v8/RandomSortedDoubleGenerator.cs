using System;
using System.Collections;

namespace lab5_v8
{
	public class RandomSortedDoubleGenerator
	{
		Random m_random_generator;

		public RandomSortedDoubleGenerator() {
			this.m_random_generator = new Random();
		}

		private double get_next(double current, double multiplier) {
			return current + multiplier * this.m_random_generator.NextDouble();
		}

		public double[] Generate(double min, double multiplier, int arrayLength) {
			double[] dataArray = new double[arrayLength];

			dataArray [0] = get_next(min, multiplier);

			for(int i = 1; i < arrayLength; i++)
			{
				dataArray[i] = get_next(dataArray[i - 1], multiplier);
			}

			return dataArray;
		}


	}
}

