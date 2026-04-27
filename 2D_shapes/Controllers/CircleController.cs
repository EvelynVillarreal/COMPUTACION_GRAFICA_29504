using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class CircleController
    {
        public bool TryCreateCircle(string radiusText, out CircleShape circle, out string error)
        {
            circle = null;
            error = null;

            if (string.IsNullOrWhiteSpace(radiusText))
            {
                error = "El radio es requerido.";
                return false;
            }

            if (!double.TryParse(radiusText, out double r) || r <= 0)
            {
                error = "Ingrese un valor numérico válido y mayor que cero para el radio.";
                return false;
            }

            circle = new CircleShape(r);
            return true;
        }
    }
}
