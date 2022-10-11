using System;
using System.IO;
using System.Text;

namespace _03._WritingTextToFile
{
    class WritingTextToFile
    {
        static void Main(string[] args)
        {
            string text = "Всеки ден, малката мравка пристигаше рано на работното си място и започваше да работи.";
            string path = Path.Combine("../../../output.txt");

            FileStream stream = new FileStream(path, FileMode.Create);

            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                stream.Write(bytes, 0, bytes.Length);
            }
            finally
            {
                stream.Flush();
            }
        
        }
    }
}
