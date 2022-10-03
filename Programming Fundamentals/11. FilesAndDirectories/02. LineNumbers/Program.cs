using System;
using System.IO;
using System.Linq;

namespace _02._LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\";
            string[] text = File.ReadAllLines($"{path}\\input.txt");
            File.WriteAllLines($"{path}\\output.txt", text.Select((l, i) => $"{i+1}. {l}").ToArray());
        }
    }
}
