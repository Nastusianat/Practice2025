using System;

namespace RectangleLibrary
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public double GetArea()
        {
            return Width * Height;
        }
    }
}
