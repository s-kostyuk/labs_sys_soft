using System;
using System.Collections.Generic;

namespace lab5_v8
{
	public static class SortedEnumerablesMerger<T> // Обобщение: нужный тип указывается в <скобках>
		where T: IComparable // При этом тип должен обладать интерфейсом IComparable
	{
		/// <summary>
		/// Merge: Метод-итератор (https://msdn.microsoft.com/en-us/library/mt639331.aspx).
		/// Берет два перечисляемых объекта (IEnumerable) с элементами типа T на вход и выдает
		/// перечисляемый объект того же типа на выход. Грубо говоря.
		/// </summary>
		/// <param name="source1">Первый объект (отсортированная в порядке возрастания коллекция).</param>
		/// <param name="source2">Второй объект (отсортированная в порядке возрастания коллекция).</param>
		public static IEnumerable<T> Merge (
			IEnumerable<T> source1,
			IEnumerable<T> source2
		)
		{
			// Получаем два энумератора (аналог итератора в C++)
			IEnumerator<T> en1 = source1.GetEnumerator ();
			IEnumerator<T> en2 = source2.GetEnumerator ();

			// Переставляем позиции итераторов на первые элементы коллекций.
			bool has_next_1 = en1.MoveNext (); // Если коллекции пусты, то has_next == false
			bool has_next_2 = en2.MoveNext ();

			while (true) {
				// Если закончилась первая коллекция - копируем до конца вторую и вываливаемся
				if (!has_next_1) { // Если элементы в первой коллекции закончились...
					while (has_next_2) { // ...перебираем все оставшиеся элементы второй коллекции.
						yield return en2.Current; // Возвращаем текущий элемент второй коллекции
						has_next_2 = en2.MoveNext (); // Передвигаемся к след. элементу
					}

					break;
				}

				// Если закончилась вторая коллекция - копируем до конца первую и вываливаемся
				if (!has_next_2) {
					while (has_next_1) {
						yield return en1.Current; // Возвращаем текущий элемент первой коллекции
						has_next_1 = en1.MoveNext ();
					}

					break;
				}

				// Иначе - выбираем новые элементы. Берем самый маленький элемент из двух коллекций
				if ((en1.Current).CompareTo (en2.Current) < 0) { // Если элемент в 1-й меньше, чем во второй...
					yield return en1.Current; // ...возвращаем его...

					has_next_1 = en1.MoveNext (); // ...и переходим к след. элементу.
				} 
				else { // Если элемент во 2-й меньше, чем во первой (либо они равны)...
					yield return en2.Current; // ...возвращаем его...

					has_next_2 = en2.MoveNext ();  // ...и переходим к след. элементу.
				}

			}

		}


	}
}

