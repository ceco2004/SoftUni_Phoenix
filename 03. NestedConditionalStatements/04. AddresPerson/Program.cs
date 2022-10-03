using System;

namespace _04._AddresPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            string addres = string.Empty;

            if(gender == "m")
            {
                if(age >= 16)
                {
                    addres = "Mr.";
                }
                else
                {
                    addres = "Master";
                }
            }
            else if (gender == "f")
            {
                if(age >= 16)
                {
                    addres = "Ms.";
                }
                else
                {
                    addres = "Misis";
                }
            }

            Console.WriteLine(addres);
        }
    }
}
