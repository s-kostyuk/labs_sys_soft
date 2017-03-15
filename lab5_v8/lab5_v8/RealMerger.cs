using System;

namespace lab5_v8
{
	public class RealMerger
	{
		public delegate void ElementWriter(double new_element);
		private ElementWriter writer = DummyWriter;

		public void SetWriter( ElementWriter w ) {
			writer = w;
		}

		private static void DummyWriter( double new_element) {
			
		}

		public void Merge (
			ref double[] arr1,
			ref double[] arr2
		)
		{
			ISortedRealEnumerator en1 = new RealArrayEnumerator (arr1);
			ISortedRealEnumerator en2 = new RealArrayEnumerator (arr2);

			Merge (ref en1, ref en2);

		}

		public void Merge (
			ref ISortedRealEnumerator en1,
			ref ISortedRealEnumerator en2
		) 
		{
//			en1.next ();
//			en2.next ();

			while (true) {
				// Если закончился первый массив - копируем до конца второй и вываливаемся
				if (en1.is_end) {
					while (!en2.is_end) {
						this.writer (en2.next ());
					}

					break;
				}

				// Если закончился второй массив - копируем до конца первый и вываливаемся
				if (en2.is_end) {
					while (!en1.is_end) {
						this.writer (en1.next());
					}

					break;
				}

				// Иначе - выбираем новые элементы
				if (en1.item() < en2.item()) {  // Если в первом массиве меньшее число - записываем его и идем дальше
					this.writer (en1.item());

					en1.next ();
				} else {
					this.writer (en2.item());

					en2.next ();
				}

			}

		}
	}
}

