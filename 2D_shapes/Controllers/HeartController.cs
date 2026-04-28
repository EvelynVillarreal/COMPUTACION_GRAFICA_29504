using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class HeartController
    {
        public bool TryCreateHeart(string widthText, out Heart heart, out string error)
        {
            heart = null;
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

            try
            {
                heart = new Heart(w);
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