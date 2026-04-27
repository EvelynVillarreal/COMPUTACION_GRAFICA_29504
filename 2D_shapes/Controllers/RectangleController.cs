using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class RectangleController
    {
        public bool TryCreateRectangle(string widthText, string lengthText, out RectangleShape rectangle, out string error)
        {
            rectangle = null;
            error = null;

            if (!double.TryParse(widthText, out double width) || !double.TryParse(lengthText, out double length))
            {
                error = "Ingrese valores numéricos válidos para ancho y largo.";
                return false;
            }
            if (width <= 0 || length <= 0)
            {
                error = "Ancho y largo deben ser mayores que cero.";
                return false;
            }

            rectangle = new RectangleShape(width, length);
            return true;
        }
    }
}
