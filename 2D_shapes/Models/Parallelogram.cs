using System;

namespace _2D_shapes.Models
{
    public class Parallelogram : IShape
    {
        public double Base { get; private set; }
        public double Height { get; private set; }

        public Parallelogram(double b, double h)
        {
            if (b <= 0 || h <= 0) throw new ArgumentException("Base and height must be positive");
            Base = b;
            Height = h;
        }

        public double Area => Base * Height;

        public double Perimeter => 2 * (Base + Height);
    }
}