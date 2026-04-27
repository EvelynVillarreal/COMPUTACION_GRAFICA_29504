using System;
using _2D_shapes.Models;

namespace _2D_shapes.Controllers
{
    public class HexagonController
    {
        public bool TryCreateHexagon(string sideText, out Hexagon hexagon, out string error)
        {
            hexagon = null;
            error = null;

            if (!double.TryParse(sideText, out double s) || s <= 0)
            {
                error = "Ingrese un valor numérico válido y mayor que cero para el lado.";
                return false;
            }

            hexagon = new Hexagon(s);
            return true;
        }
    }
}
