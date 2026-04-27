using System;

namespace _2D_shapes.Models
{
    public class Semicircle : IShape
    {
        public double Radius { get; private set; }

        public Semicircle(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Radius must be positive", nameof(radius));
            Radius = radius;
        }

        public double Area => (Math.PI * Radius * Radius) / 2.0;

        public double Perimeter => Math.PI * Radius + 2 * Radius;
    }
}
