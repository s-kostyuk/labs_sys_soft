using System;

namespace lab5_v8
{
	class RealArrayEnumerator : ISortedRealEnumerator
	{
		private double[] m_array;
		private int index = 0;

		public RealArrayEnumerator (double[] _array)
		{
			this.m_array = _array;
		}

		public double next() {
			return this.m_array[index++];
		}

		public double item() {
			return this.m_array[index];
		}

		public bool is_end {
			get {
				return this.index >= this.m_array.Length || this.m_array.Length == 0;
			}
		}

	}
}

