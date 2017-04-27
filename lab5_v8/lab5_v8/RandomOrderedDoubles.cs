using System;
using System.Collections;
using System.Collections.Generic;

namespace lab5_v8
{
	public static class RandomOrderedDoubles
	{
		private static double get_next(Random random, double current, double multiplier) {
			return current + multiplier * random.NextDouble();
		}

		/// <summary>
		/// Гегератор последовательности случайно увеличивающихся значений
		/// </summary>
		/// <param name="min">Минимальное значение</param>
		/// <param name="multiplier">Множитель (максимальный шаг)</param>
		/// <param name="nOfNumbers">Количество генерируемых чисел</param>
		public static IEnumerable<double> Generator(double min, double multiplier, int nOfNumbers) {
			double current = min;
			Random random = new Random();

			for(int i = 0; i < nOfNumbers; i++)
			{
				current = get_next(random, current, multiplier);
				yield return current;
			}
		}

	}
}

