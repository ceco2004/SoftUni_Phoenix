using System;
using System.IO;
using System.Linq;

namespace _02._WriteToFile
{
    class WriteToFile
    {
        static void Main(string[] args)
        {
            string path = "../../..";
            string fileSource = "WriteToFile.cs";
            string fileOutput = "reverced.txt";

            string sourcePath = Path.Combine(path, fileSource);
            string outputPath = Path.Combine(path, fileOutput);

            using(StreamReader reader = new StreamReader(sourcePath))
            {
                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(string.Join("", line.Reverse()));
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
