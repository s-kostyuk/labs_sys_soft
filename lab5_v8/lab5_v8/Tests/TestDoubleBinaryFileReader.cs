using NUnit.Framework;
using System;
using System.IO;
using System.Collections;

namespace lab5_v8
{
	[TestFixture ()]
	public class TestDoubleBinaryFileReader
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
				new BinaryWriter (new FileStream("/tmp/test_file", FileMode.Create))) 
			{
				// Write the data to the stream.
				Console.WriteLine ("Writing data to the stream.");
				for (i = 0; i < arrayLength; i++) {
					binWriter.Write (dataArray [i]);
				}
			}

			// Create a reader using the stream from the writer.
			IEnumerator enumer = 
				DoubleBinaryFileReader.Read ("/tmp/test_file").GetEnumerator();

			for (i = 0; i < arrayLength; i++) {
				enumer.MoveNext ();

				Assert.AreEqual (dataArray [i], enumer.Current);
			}

			enumer.MoveNext ();
			enumer.MoveNext ();
			System.Console.Write(enumer.Current);
		}
	}
}

