using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class KiteController
    {
        public bool TryCreateKite(string d1Text, string d2Text, out Kite kite, out string error)
        {
            kite = null;
            error = null;

            if (string.IsNullOrWhiteSpace(d1Text))
            {
                error = "La diagonal 1 es requerida.";
                return false;
            }

            if (!double.TryParse(d1Text, out double d1) || d1 <= 0)
            {
                error = "Ingrese un valor numérico válido y mayor que cero para la diagonal 1.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(d2Text))
            {
                error = "La diagonal 2 es requerida.";
                return false;
            }

            if (!double.TryParse(d2Text, out double d2) || d2 <= 0)
            {
                error = "Ingrese un valor numérico válido y mayor que cero para la diagonal 2.";
                return false;
            }

            try
            {
                kite = new Kite(d1, d2);
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