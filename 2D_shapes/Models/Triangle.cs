using System;

namespace _2D_shapes.Models
{
    public class Triangle : IShape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("Sides must be positive");
            if (a + b <= c || a + c <= b || b + c <= a) throw new ArgumentException("Invalid triangle sides");
            A = a; B = b; C = c;
        }

        public double Perimeter => A + B + C;

        public double Area
        {
            get
            {
                double s = Perimeter / 2.0;
                return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
            }
        }

        public string TriangleType
        {
            get
            {
                double[] lados = new double[] { A, B, C };
                Array.Sort(lados);
                double l1 = lados[0];
                double l2 = lados[1];
                double l3 = lados[2];
                double epsilon = 0.0001;
                bool isRightAngled = Math.Abs(Math.Pow(l3, 2) - (Math.Pow(l1, 2) + Math.Pow(l2, 2))) < epsilon;

                if (isRightAngled) return "Right-angled";
                if (Math.Abs(A - B) < epsilon && Math.Abs(B - C) < epsilon) return "Equilateral";
                if (Math.Abs(A - B) < epsilon || Math.Abs(B - C) < epsilon || Math.Abs(A - C) < epsilon) return "Isosceles";
                return "Scalene";
            }
        }
    }
}
