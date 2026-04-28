using System;

namespace _2D_shapes.Models
{
    public class Cross : IShape
    {
        public double Width { get; private set; }
        public double Length { get; private set; }

        public Cross(double width, double length)
        {
            if (width <= 0 || length <= 0) throw new ArgumentException("Width and length must be positive");
            Width = width;
            Length = length;
        }

        public double Area => 3 * Width * Length;

        public double Perimeter => 8 * Width + 4 * (Length - 2 * Width);
    }
}