using System;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            Drawable rectangle = new Rectangle();
            Drawable circle = new Circle();
            Drawable square = new Square();

            GraphicEditor editor = new GraphicEditor();
            editor.DrawShape(rectangle);
            editor.DrawShape(circle);
            editor.DrawShape(square);
        }
    }
}
