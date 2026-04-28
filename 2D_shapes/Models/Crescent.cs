using System;

namespace _2D_shapes.Models
{
    public class Crescent : IShape
    {
        public double OuterRadius { get; private set; }
        public double InnerRadius { get; private set; }

        public Crescent(double outerRadius, double innerRadius)
        {
            if (outerRadius <= 0 || innerRadius <= 0)
                throw new ArgumentException("Radius must be positive");

            if (innerRadius >= outerRadius)
                throw new ArgumentException("Inner radius must be less than outer radius");

            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }

        // Distancia entre centros (MISMA lógica que el dibujo)
        private double D => 0.5 * OuterRadius;

        public double Area
        {
            get
            {
                double R = OuterRadius;
                double r = InnerRadius;
                double d = D;

                if (d >= R + r)
                    return Math.PI * R * R;

                if (d <= Math.Abs(R - r))
                    return Math.PI * (R * R - r * r);

                double part1 = R * R * Math.Acos((d * d + R * R - r * r) / (2 * d * R));
                double part2 = r * r * Math.Acos((d * d + r * r - R * R) / (2 * d * r));
                double part3 = 0.5 * Math.Sqrt(
                    (-d + R + r) *
                    (d + R - r) *
                    (d - R + r) *
                    (d + R + r)
                );

                double intersection = part1 + part2 - part3;

                return Math.PI * R * R - intersection;
            }
        }

        public double Perimeter
        {
            get
            {
                double R = OuterRadius;
                double r = InnerRadius;
                double d = D;

                double angle1 = 2 * Math.Acos((d * d + R * R - r * r) / (2 * d * R));
                double angle2 = 2 * Math.Acos((d * d + r * r - R * R) / (2 * d * r));

                double arcBig = R * angle1;
                double arcSmall = r * angle2;

                return arcBig + arcSmall;
            }
        }
    }
}