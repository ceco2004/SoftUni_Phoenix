using System;

namespace Ex05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            string msg = string.Empty;

            for(int i = 0; i < tabs; i++)
            {
                string site = Console.ReadLine();
                switch (site)
                {
                    case "Facebook": salary -= 150; break;
                    case "Instagram": salary -= 100; break;
                    case "Reddit": salary -= 50; break;
                }

                if(salary <= 0)
                {
                    msg = "You have lost your salary.";
                    break;
                }
            }

            if(msg == string.Empty)
            {
                msg = salary.ToString();
            }
            Console.WriteLine(msg);
        }
    }
}
