using System;
using System.Collections;

namespace lab5_v8
{
	public class SortedMerger
	{
		public delegate void ElementWriter(object new_element);
		private ElementWriter writer = DummyWriter;

		public void SetWriter( ElementWriter w ) {
			writer = w;
		}

		private static void DummyWriter( object new_element) {
			
		}

		public void Merge (
			IEnumerator en1,
			IEnumerator en2
		) 
		{
			bool has_next_1 = en1.MoveNext ();
			bool has_next_2 = en2.MoveNext ();

			while (true) {
				// Если закончился первый массив - копируем до конца второй и вываливаемся
				if (! has_next_1) {
					while (has_next_2) {
						this.writer (en2.Current);
						has_next_2 = en2.MoveNext ();
					}

					break;
				}

				// Если закончился второй массив - копируем до конца первый и вываливаемся
				if (! has_next_2) {
					while (has_next_1) {
						this.writer (en1.Current);
						has_next_1 = en1.MoveNext ();
					}

					break;
				}

				// Иначе - выбираем новые элементы
				if (((IComparable)en1.Current).CompareTo((IComparable)en2.Current) < 0) {  // Если в первом массиве меньшее число - записываем его и идем дальше
					this.writer (en1.Current);

					has_next_1 = en1.MoveNext ();
				} else {
					this.writer (en2.Current);

					has_next_2 = en2.MoveNext ();
				}

			}

		}
	}
}

