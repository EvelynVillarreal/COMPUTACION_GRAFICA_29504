using System;

namespace _2D_shapes.Models
{
    public class Hexagon : IShape
    {
        public double Side { get; private set; }

        public Hexagon(double side)
        {
            if (side <= 0) throw new ArgumentException("Side must be positive", nameof(side));
            Side = side;
        }

        public double Perimeter => 6 * Side;

        public double Area => (3 * Math.Sqrt(3) / 2) * Side * Side;
    }
}
