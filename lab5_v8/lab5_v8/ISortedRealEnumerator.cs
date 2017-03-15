using System;

namespace lab5_v8
{
	public interface ISortedRealEnumerator
	{
		// После создания - сразу готов выдавать данные
		// next - получить след. эелемент
		double next();

		// item - получить текущий элемент
		double item();

		bool is_end {
			get;
		}
	}
}

