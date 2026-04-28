using System;

namespace _2D_shapes.Models
{
    public class Pentagon : IShape
    {
        public double Side { get; private set; }

        public Pentagon(double side)
        {
            if (side <= 0) throw new ArgumentException("Side must be positive", nameof(side));
            Side = side;
        }

        public double Area => (Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4) * Side * Side;

        public double Perimeter => 5 * Side;
    }
}