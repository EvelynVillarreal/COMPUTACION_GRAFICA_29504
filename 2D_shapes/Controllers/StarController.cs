using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class StarController
    {
        public bool TryCreateStar(string outerRadiusText, string innerRadiusText, int points, out Star star, out string error)
        {
            star = null;
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

            if (points < 3)
            {
                error = "Debe tener al menos 3 puntas.";
                return false;
            }

            try
            {
                star = new Star(or, ir, points);
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