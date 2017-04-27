using System;
using System.Collections.Generic;
using System.IO;

namespace lab5_v8
{
    public static class BinaryDoublesFileGenerator
    {

        /*-------------------------------------------------------------------*/

        public static void GenerateRandomSortedSequence(string path, double min, double multiplier, int nOfNumbers)
        {
            EnumerableToFile(
                RandomOrderedDoubles.Generator(min, multiplier, nOfNumbers),
                path
            );
        }

        /*-------------------------------------------------------------------*/

        public static void EnumerableToFile(IEnumerable<double> source, string path)
        {
            Stream target = File.Open(path, FileMode.OpenOrCreate);

            BinaryWriter writer = new BinaryWriter(target);

            foreach (double item in source)
            {
                writer.Write(item);
            }

            writer.Close();
            writer.Dispose();

            target.Close();
            target.Dispose();
        }

        /*-------------------------------------------------------------------*/

    }
}
