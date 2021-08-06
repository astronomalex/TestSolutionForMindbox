using System;
using System.Linq;
using SquareLibrary.Exceptions;

namespace SquareLibrary.Models
{
    public class Triangle : IFigure
    {
        private readonly double[] _sides;

        public Triangle(double side1, double side2, double side3)
        {
            _sides = new[] {side1, side2, side3};

            if (side1 <= 0) throw new ArgumentOutOfRangeException(nameof(side1));
            if (side2 <= 0) throw new ArgumentOutOfRangeException(nameof(side2));
            if (side3 <= 0) throw new ArgumentOutOfRangeException(nameof(side3));

            if (side1 > side2 + side3 || side2 > side1 + side3 || side3 > side1 + side2)
            {
                throw new IsNotTriangleException("It's not a triangle");
            }

            Array.Sort(_sides);
        }

        public double GetSquare()
        {
            return IsRightTriangle() ? GetRightTriangleSquare() : GetTriangleSquare();
        }

        private double GetTriangleSquare()
        {
            var halfPer = _sides.Sum() / 2D;
            return Math.Sqrt(halfPer * (halfPer - _sides[0]) * (halfPer - _sides[1]) * (halfPer - _sides[2]));
        }

        private double GetRightTriangleSquare()
        {
            return _sides[0] * _sides[1] / 2D;
        }

        private bool IsRightTriangle()
        {
            return Math.Pow(_sides[2], 2).Equals(Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2));
        }
    }
}