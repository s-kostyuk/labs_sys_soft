using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace lab5_v8
{
	public class BinaryFileDoubleEnumerator : IEnumerator<double>
	{
		private BinaryReader m_reader;
		private double m_current;
		private bool m_is_got_first = false;
		private bool m_elements_left = true;

		public void Dispose() {
			m_reader.Dispose ();
		}

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

		public double Current {
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

		private object Current1
		{

			get { return this.Current; }
		}

		object IEnumerator.Current
		{
			get { return Current1; }
		}

		public void Reset()
		{
			this.m_reader.BaseStream.Position = 0;
		}

	}

	public class BinaryFileDoubleEnumerable : IEnumerable<double>
	{
		private string m_filename;

		public BinaryFileDoubleEnumerable (string fileName)
		{
			this.m_filename = fileName;
		}

		public IEnumerator<double> GetEnumerator()
		{
			return new BinaryFileDoubleEnumerator (
				File.Open (this.m_filename, FileMode.Open)
			);
		}

		private IEnumerator GetEnumerator1()
		{
			return this.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator1();
		}

	}
}

