using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class TrefoilController
    {
        public bool TryCreateTrefoil(string radiusText, out Trefoil trefoil, out string error)
        {
            trefoil = null;
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
                trefoil = new Trefoil(r);
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