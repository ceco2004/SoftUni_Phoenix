﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P02.Graphic_Editor
{
    public class GraphicEditor
    {
        public void DrawShape(Drawable shape)
        {
            Console.WriteLine(shape.Draw());
        }
    }
}
