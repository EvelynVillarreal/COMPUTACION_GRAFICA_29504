using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class CrossController
    {
        public bool TryCreateCross(string widthText, string lengthText, out Cross cross, out string error)
        {
            cross = null;
            error = null;

            if (string.IsNullOrWhiteSpace(widthText))
            {
                error = "El ancho es requerido.";
                return false;
            }

            if (!double.TryParse(widthText, out double w) || w <= 0)
            {
                error = "Ingrese un valor numérico válido y mayor que cero para el ancho.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(lengthText))
            {
                error = "La longitud es requerida.";
                return false;
            }

            if (!double.TryParse(lengthText, out double l) || l <= 0)
            {
                error = "Ingrese un valor numérico válido y mayor que cero para la longitud.";
                return false;
            }

            try
            {
                cross = new Cross(w, l);
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