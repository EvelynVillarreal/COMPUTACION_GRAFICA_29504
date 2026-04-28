using System;

namespace _2D_shapes.Models
{
    public class QuarterCircle : IShape
    {
        public double Radius { get; private set; }

        public QuarterCircle(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Radius must be positive", nameof(radius));
            Radius = radius;
        }

        public double Area => (Math.PI * Radius * Radius) / 4;

        public double Perimeter => (Math.PI * Radius) / 2 + 2 * Radius;
    }
}