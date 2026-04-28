using System;

namespace _2D_shapes.Models
{
    public class Trapezoid : IShape
    {
        public double Base1 { get; private set; }
        public double Base2 { get; private set; }
        public double Height { get; private set; }

        public Trapezoid(double b1, double b2, double h)
        {
            if (b1 <= 0 || b2 <= 0 || h <= 0) throw new ArgumentException("All values must be positive");
            Base1 = b1;
            Base2 = b2;
            Height = h;
        }

        public double Area => ((Base1 + Base2) / 2) * Height;

        public double Perimeter
        {
            get
            {
                double leg = Math.Sqrt(Math.Pow((Base2 - Base1) / 2, 2) + Height * Height);
                return Base1 + Base2 + 2 * leg;
            }
        }
    }
}