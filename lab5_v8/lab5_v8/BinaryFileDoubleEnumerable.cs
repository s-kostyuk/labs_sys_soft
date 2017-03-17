using System;
using System.IO;
using System.Collections;

namespace lab5_v8
{
	public class BinaryFileDoubleEnumerator : IEnumerator
	{
		private BinaryReader m_reader;
		private double m_current;
		private bool m_is_got_first = false;
		private bool m_elements_left = true;

		public BinaryFileDoubleEnumerator(Stream input)
		{
			m_reader = new BinaryReader (input);
		}

		public bool MoveNext() {
			this.m_is_got_first = true;

			if (this.m_elements_left) {
				try {
					this.m_current = this.m_reader.ReadDouble ();
				}
				catch (EndOfStreamException) {
					this.m_elements_left = false;
				}
			}

			return this.m_elements_left;
		}

		public object Current {
			get {
				if (!this.m_is_got_first) {
					throw new InvalidOperationException ("MoveNext() must be called at least once");
				}

				if (!this.m_elements_left) {
					throw new InvalidOperationException ("End of file");
				}

				return this.m_current;
			}
		}

		public void Reset()
		{
			this.m_reader.BaseStream.Position = 0;
		}

	}

	public class BinaryFileDoubleEnumerable : IEnumerable
	{
		private string m_filename;

		public BinaryFileDoubleEnumerable (string fileName)
		{
			this.m_filename = fileName;
		}

		public IEnumerator GetEnumerator()
		{
			return new BinaryFileDoubleEnumerator (
				File.Open (this.m_filename, FileMode.Open)
			);
		}
	}
}

