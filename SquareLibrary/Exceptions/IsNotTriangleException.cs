using System;

namespace SquareLibrary.Exceptions
{
    public class IsNotTriangleException : Exception
    {
        public IsNotTriangleException(string message) : base(message)
        {
        }
    }
}