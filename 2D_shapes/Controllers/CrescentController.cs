using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class CrescentController
    {
        public bool TryCreateCrescent(string outerRadiusText, string innerRadiusText, out Crescent crescent, out string error)
        {
            crescent = null;
            error = null;

            if (string.IsNullOrWhiteSpace(outerRadiusText))
            {
                error = "El radio exterior es requerido.";
                return false;
            }

            if (!double.TryParse(outerRadiusText, out double or) || or <= 0)
            {
                error = "Ingrese un valor numérico válido y mayor que cero para el radio exterior.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(innerRadiusText))
            {
                error = "El radio interior es requerido.";
                return false;
            }

            if (!double.TryParse(innerRadiusText, out double ir) || ir <= 0)
            {
                error = "Ingrese un valor numérico válido y mayor que cero para el radio interior.";
                return false;
            }

            if (ir >= or)
            {
                error = "El radio interior debe ser menor que el radio exterior.";
                return false;
            }

            try
            {
                crescent = new Crescent(or, ir);
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