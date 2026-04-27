using System;

namespace _2D_shapes.Models
{
    /// <summary>
    /// Interfaz básica para formas 2D
    /// </summary>
    public interface IShape
    {
        double Area { get; }
        double Perimeter { get; }
    }
}
