using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class QuarterCircleController
    {
        public bool TryCreateQuarterCircle(string radiusText, out QuarterCircle quarterCircle, out string error)
        {
            quarterCircle = null;
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

            try
            {
                quarterCircle = new QuarterCircle(r);
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