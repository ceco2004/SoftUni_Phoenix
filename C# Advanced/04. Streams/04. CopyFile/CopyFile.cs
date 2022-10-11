using System;
using System.IO;
using System.Linq;

namespace _04._CopyFile
{
    class CopyFile
    {
        static void Main(string[] args)
        {
            string sourcePath = Path.Combine("../../../ForAnt.txt");
            string outputPath = Path.Combine("../../../copy.txt");

            using (FileStream source = new FileStream(sourcePath, FileMode.Open))
            {
                using (FileStream destination = new FileStream(outputPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024];
                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    while(readBytes > 0)
                    {
                        destination.Write(buffer, 0, Math.Min(readBytes, buffer.Length));
                        readBytes = source.Read(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
