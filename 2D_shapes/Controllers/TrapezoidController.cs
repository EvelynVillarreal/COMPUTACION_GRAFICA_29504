using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class TrapezoidController
    {
        public bool TryCreateTrapezoid(string b1Text, string b2Text, string hText, out Trapezoid trapezoid, out string error)
        {
            trapezoid = null;
            error = null;

            if (string.IsNullOrWhiteSpace(b1Text))
            {
                error = "La base 1 es requerida.";
                return false;
            }

            if (!double.TryParse(b1Text, out double b1) || b1 <= 0)
            {
                error = "Ingrese un valor numérico válido y mayor que cero para la base 1.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(b2Text))
            {
                error = "La base 2 es requerida.";
                return false;
            }

            if (!double.TryParse(b2Text, out double b2) || b2 <= 0)
            {
                error = "Ingrese un valor numérico válido y mayor que cero para la base 2.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(hText))
            {
                error = "La altura es requerida.";
                return false;
            }

            if (!double.TryParse(hText, out double h) || h <= 0)
            {
                error = "Ingrese un valor numérico válido y mayor que cero para la altura.";
                return false;
            }

            try
            {
                trapezoid = new Trapezoid(b1, b2, h);
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}