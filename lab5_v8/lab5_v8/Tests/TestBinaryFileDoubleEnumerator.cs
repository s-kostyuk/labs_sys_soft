using NUnit.Framework;
using System;
using System.IO;

namespace lab5_v8
{
	[TestFixture ()]
	public class TestBinaryFileDoubleEnumerator
	{
		// https://msdn.microsoft.com/en-us/library/system.io.binaryreader.readdouble(v=vs.110).aspx
		[Test ()]
		public void TestIterations ()
		{
			int i;
			const int arrayLength = 1000;

			// Create random data to write to the stream.
			Random randomGenerator = new Random();
			double[] dataArray = new double[arrayLength];
			for(i = 0; i < arrayLength; i++)
			{
				dataArray[i] = 100.1 * randomGenerator.NextDouble();
			}

			using (BinaryWriter binWriter = 
				      new BinaryWriter (new MemoryStream ())) 
			{
				// Write the data to the stream.
				Console.WriteLine ("Writing data to the stream.");
				for (i = 0; i < arrayLength; i++) {
					binWriter.Write (dataArray [i]);
				}

				// Create a reader using the stream from the writer.
				BinaryFileDoubleEnumerator enumer = 
					new BinaryFileDoubleEnumerator (binWriter.BaseStream);

				// Return to the beginning of the stream.
				enumer.Reset ();

				for (i = 0; i < arrayLength; i++) {
					enumer.MoveNext ();

					Assert.AreEqual (dataArray [i], enumer.Current);
				}
			}
		}
	}
}

