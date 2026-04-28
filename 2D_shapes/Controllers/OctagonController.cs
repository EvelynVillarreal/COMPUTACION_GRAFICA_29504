using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class OctagonController
    {
        public bool TryCreateOctagon(string sideText, out Octagon octagon, out string error)
        {
            octagon = null;
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
                octagon = new Octagon(s);
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