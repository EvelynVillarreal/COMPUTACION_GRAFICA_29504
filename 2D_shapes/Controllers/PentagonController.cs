using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class PentagonController
    {
        public bool TryCreatePentagon(string sideText, out Pentagon pentagon, out string error)
        {
            pentagon = null;
            error = null;

            if (string.IsNullOrWhiteSpace(sideText))
            {
                error = "El lado es requerido.";
                return false;
            }

            if (!double.TryParse(sideText, out double s) || s <= 0)
            {
                error = "Ingrese un valor numérico válido y mayor que cero para el lado.";
                return false;
            }

            try
            {
                pentagon = new Pentagon(s);
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