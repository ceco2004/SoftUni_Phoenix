using System;
using System.Collections.Generic;
using System.Text;

namespace P02.Graphic_Editor
{
    public abstract class Drawable : IShape
    {
        public string Draw()
        {
            return $"I'm {this.GetType().Name}";
        }
    }
}
