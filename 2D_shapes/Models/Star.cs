using System;

namespace _2D_shapes.Models
{
    public class Star : IShape
    {
        public double OuterRadius { get; private set; }
        public double InnerRadius { get; private set; }
        public int Points { get; private set; }

        public Star(double outerRadius, double innerRadius, int points = 5)
        {
            if (outerRadius <= 0) throw new ArgumentException("Outer radius must be positive", nameof(outerRadius));
            if (innerRadius <= 0) throw new ArgumentException("Inner radius must be positive", nameof(innerRadius));
            if (innerRadius >= outerRadius) throw new ArgumentException("Inner radius must be less than outer radius");
            if (points < 3) throw new ArgumentException("Points must be at least 3", nameof(points));

            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Points = points;
        }

        public double Area
        {
            get
            {
                double area = 0;
                for (int i = 0; i < Points * 2; i++)
                {
                    double r = (i % 2 == 0) ? OuterRadius : InnerRadius;
                    double angle = Math.PI * i / Points - Math.PI / 2;
                    double nextAngle = Math.PI * (i + 1) / Points - Math.PI / 2;
                    double nextR = (i % 2 == 0) ? InnerRadius : OuterRadius;

                    area += 0.5 * r * nextR * Math.Sin(nextAngle - angle);
                }
                return Math.Abs(area);
            }
        }

        public double Perimeter
        {
            get
            {
                double perimeter = 0;
                for (int i = 0; i < Points * 2; i++)
                {
                    double r = (i % 2 == 0) ? OuterRadius : InnerRadius;
                    double angle = Math.PI * i / Points - Math.PI / 2;
                    double nextR = (i % 2 == 0) ? InnerRadius : OuterRadius;
                    double nextAngle = Math.PI * (i + 1) / Points - Math.PI / 2;

                    double dx = r * Math.Cos(angle) - nextR * Math.Cos(nextAngle);
                    double dy = r * Math.Sin(angle) - nextR * Math.Sin(nextAngle);
                    perimeter += Math.Sqrt(dx * dx + dy * dy);
                }
                return perimeter;
            }
        }
    }
}