using System;

namespace _2D_shapes.Models
{
    public class Trefoil : IShape
    {
        public double Radius { get; private set; }

        public Trefoil(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Radius must be positive", nameof(radius));
            Radius = radius;
        }

        public double Area => 3 * Math.PI * Radius * Radius;

        public double Perimeter => 6 * Math.PI * Radius;
    }
}