using System;

namespace _2D_shapes.Models
{
    public class Rhombus : IShape
    {
        public double Diagonal1 { get; private set; }
        public double Diagonal2 { get; private set; }

        public Rhombus(double d1, double d2)
        {
            if (d1 <= 0 || d2 <= 0) throw new ArgumentException("Diagonals must be positive");
            Diagonal1 = d1;
            Diagonal2 = d2;
        }

        public double Area => (Diagonal1 * Diagonal2) / 2;

        public double Perimeter => 2 * Math.Sqrt(Math.Pow(Diagonal1, 2) + Math.Pow(Diagonal2, 2));
    }
}