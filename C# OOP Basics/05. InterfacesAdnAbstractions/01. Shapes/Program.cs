using _01._Shapes.Interfaces;
using _01._Shapes.Models;
using System;

namespace _01._Shapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDrawable rect = new Rectangle(5, 5);
            rect.Draw();
        }
    }
}
