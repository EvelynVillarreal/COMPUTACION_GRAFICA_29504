using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class ParallelogramController
    {
        public bool TryCreateParallelogram(string baseText, string heightText, out Parallelogram parallelogram, out string error)
        {
            parallelogram = null;
            error = null;

            if (string.IsNullOrWhiteSpace(baseText))
            {
                error = "La base es requerida.";
                return false;
            }

            if (!double.TryParse(baseText, out double b) || b <= 0)
            {
                error = "Ingrese un valor numérico válido y mayor que cero para la base.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(heightText))
            {
                error = "La altura es requerida.";
                return false;
            }

            if (!double.TryParse(heightText, out double h) || h <= 0)
            {
                error = "Ingrese un valor numérico válido y mayor que cero para la altura.";
                return false;
            }

            try
            {
                parallelogram = new Parallelogram(b, h);
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