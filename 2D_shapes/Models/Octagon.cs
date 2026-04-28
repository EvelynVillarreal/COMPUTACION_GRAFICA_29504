using System;

namespace _2D_shapes.Models
{
    public class Octagon : IShape
    {
        public double Side { get; private set; }

        public Octagon(double side)
        {
            if (side <= 0) throw new ArgumentException("Side must be positive", nameof(side));
            Side = side;
        }

        public double Area => 2 * (1 + Math.Sqrt(2)) * Side * Side;

        public double Perimeter => 8 * Side;
    }
}