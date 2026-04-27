using System;

namespace _2D_shapes.Models
{
    public class CircleShape : IShape
    {
        public double Radius { get; private set; }

        public CircleShape(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Radius must be positive", nameof(radius));
            Radius = radius;
        }

        public double Area => Math.PI * Radius * Radius;

        public double Perimeter => 2 * Math.PI * Radius;
    }
}
