using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class EllipseController
    {
        public bool TryCreateEllipse(string majorText, string minorText, out Ellipse ellipse, out string error)
        {
            ellipse = null;
            error = null;

            if (!double.TryParse(majorText, out double major) || !double.TryParse(minorText, out double minor))
            {
                error = "Ingrese valores numéricos válidos para los ejes.";
                return false;
            }
            if (major <= 0 || minor <= 0)
            {
                error = "Los ejes deben ser positivos.";
                return false;
            }
            if (major < minor)
            {
                error = "El eje mayor debe ser mayor al eje menor.";
                return false;
            }
            if (Math.Abs(major - minor) < 1e-9)
            {
                error = "Los ejes no pueden ser iguales (use Circle si son iguales).";
                return false;
            }

            ellipse = new Ellipse(major, minor);
            return true;
        }
    }
}
