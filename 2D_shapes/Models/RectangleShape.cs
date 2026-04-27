using System;

namespace _2D_shapes.Models
{
    public class RectangleShape : IShape
    {
        public double Width { get; private set; }
        public double Length { get; private set; }

        public RectangleShape(double width, double length)
        {
            if (width <= 0) throw new ArgumentException("Width must be positive", nameof(width));
            if (length <= 0) throw new ArgumentException("Length must be positive", nameof(length));
            Width = width;
            Length = length;
        }

        public double Area => Width * Length;

        public double Perimeter => 2 * (Width + Length);
    }
}
