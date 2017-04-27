using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab5_v8
{
    public static class BinarySortedDoubleFileGenerator
    {
        public static void Generate(string path, double min, double multiplier, int nOfNumbers)
        {
            Stream target = File.Open(path, FileMode.OpenOrCreate);

            BinaryWriter writer = new BinaryWriter(target);

            foreach (double item in RandomOrderedDoubles.Generator(min, multiplier, nOfNumbers))
            {
                writer.Write(item);
            }

            writer.Close();
            writer.Dispose();

            target.Close();
            target.Dispose();
        }
    }
}
