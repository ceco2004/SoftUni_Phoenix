using _01._Shapes.Interfaces;
using System;

namespace _01._Shapes.Models
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int heigth;

        public Rectangle(int width, int heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }

        public void Draw()
        {
            string line = string.Empty;
            for (int i = 0; i < heigth; i++)
            {
                if (i == 0 || i == heigth - 1)
                {
                    line = new string('*', width);
                }
                else
                {
                    line = $"*{new string(' ', width - 2)}*";
                }

                Console.WriteLine(line);
            }
        }
    }
}
