using System;

namespace _2D_shapes.Models
{
    public class Heart : IShape
    {
        public double Width { get; private set; }

        public Heart(double width)
        {
            if (width <= 0) throw new ArgumentException("Width must be positive", nameof(width));
            Width = width;
        }

        public double Area => (3 * Math.PI * Width * Width) / 8.0;

        public double Perimeter => Math.PI * Width;
    }
}