using System;

namespace SquareLibrary
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius));
            }

            _radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}