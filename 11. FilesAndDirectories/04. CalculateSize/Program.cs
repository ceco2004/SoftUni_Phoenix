using System;
using System.IO;
using System.Linq;

namespace _04._CalculateSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\TestFolder";

            var files = Directory.GetFiles(path);

            long sum = 0;

            foreach(var file in files)
            {
                FileInfo fi = new FileInfo(file);
                sum += fi.Length;
            }

            Console.WriteLine(sum / 1024.0 / 1024.0);
        }
    }
}
