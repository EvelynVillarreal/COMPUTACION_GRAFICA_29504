using System;

namespace _2D_shapes.Models
{
    public class Crescent : IShape
    {
        public double OuterRadius { get; private set; }
        public double InnerRadius { get; private set; }

        public Crescent(double outerRadius, double innerRadius)
        {
            if (outerRadius <= 0 || innerRadius <= 0) throw new ArgumentException("Radius must be positive");
            if (innerRadius >= outerRadius) throw new ArgumentException("Inner radius must be less than outer radius");
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }

        public double Area => Math.PI * (OuterRadius * OuterRadius - InnerRadius * InnerRadius);

        public double Perimeter => 2 * Math.PI * (OuterRadius + InnerRadius);
    }
}