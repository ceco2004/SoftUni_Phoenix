using Ex03._Mankind.Models;
using System;

namespace Ex03._Mankind
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Test", "Teeest", "123456");
            Console.WriteLine(student);

            Worker worker = new Worker("Test2", "Test2", 1590, 10);
            Console.WriteLine(worker);
        }
    }
}
