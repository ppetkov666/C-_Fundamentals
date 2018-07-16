using System;

namespace P02.Graphic_Editor
{
    class StartUp
    {
        static void Main()
        {
            var graphicEditor = new GraphicEditor();
            var circle = new Circle();
            var rectangle = new Rectangle();
            var square = new Square();
            graphicEditor.DrawShape(circle);
            graphicEditor.DrawShape(rectangle);
            graphicEditor.DrawShape(square);



        }
    }
}
