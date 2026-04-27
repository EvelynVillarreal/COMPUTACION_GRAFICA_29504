using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class TriangleController
    {
        public bool TryCreateTriangle(string aText, string bText, string cText, out Triangle triangle, out string error)
        {
            triangle = null;
            error = null;

            if (!double.TryParse(aText, out double a) || !double.TryParse(bText, out double b) || !double.TryParse(cText, out double c))
            {
                error = "Ingrese valores numéricos válidos para los lados.";
                return false;
            }
            if (a <= 0 || b <= 0 || c <= 0)
            {
                error = "Los lados deben ser mayores que cero.";
                return false;
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                error = "La suma de dos lados debe ser mayor que el tercero.";
                return false;
            }

            triangle = new Triangle(a, b, c);
            return true;
        }
    }
}
