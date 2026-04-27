using System;

namespace _2D_shapes.Models
{
    public class Ellipse : IShape
    {
        public double MajorAxis { get; private set; }
        public double MinorAxis { get; private set; }

        public Ellipse(double majorAxis, double minorAxis)
        {
            if (majorAxis <= 0) throw new ArgumentException("Major axis must be positive", nameof(majorAxis));
            if (minorAxis <= 0) throw new ArgumentException("Minor axis must be positive", nameof(minorAxis));
            if (majorAxis < minorAxis) throw new ArgumentException("Major axis must be >= minor axis");

            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
        }

        public double Area
        {
            get
            {
                double a = MajorAxis / 2.0;
                double b = MinorAxis / 2.0;
                return Math.PI * a * b;
            }
        }

        public double Perimeter
        {
            get
            {
                double a = MajorAxis / 2.0;
                double b = MinorAxis / 2.0;
                return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
            }
        }
    }
}
