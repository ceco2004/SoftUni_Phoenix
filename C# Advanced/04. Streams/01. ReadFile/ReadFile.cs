using System;
using System.IO;

namespace _01._ReadFile
{
    class ReadFile
    {
        static void Main(string[] args)
        {
            string path = "../../../";
            string fileName = "ReadFile.cs";

            path = Path.Combine(path, fileName);

            using (StreamReader reader = new StreamReader(path))
            {
                int counter = 0;

                string line = reader.ReadLine();

                while(line != null)
                {
                    Console.WriteLine($"Line {++counter}: {line}");
                    line = reader.ReadLine();
                }
                
            }
        }
    }
}
