using System;
using SquareLibrary;
using SquareLibrary.Exceptions;
using Xunit;

namespace UnitTests
{
    public class TriangleUnitTests
    {
        private readonly FiguresSquare _service;

        public TriangleUnitTests()
        {
            _service = new FiguresSquare();
        }

        [Fact]
        public void ShouldCalculateRightTriangleSquare()
        {
            var actual = _service.GetSquare(5, 4, 3);
            const double expected = 6;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldCalculateTriangleSquare()
        {
            var actual = _service.GetSquare(5, 4, 2);
            const double expected = 3.799671038392666;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldThrowExceptionIfIsNotTriangle()
        {
            Assert.Throws<IsNotTriangleException>(() => _service.GetSquare(3, 4, 8));
            Assert.Throws<IsNotTriangleException>(() => _service.GetSquare(153, 4, 8));
        }

        [Fact]
        public void ShouldThrowExceptionIfSidesAreZeroOrLess()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _service.GetSquare(-1, 5, 7));
            Assert.Throws<ArgumentOutOfRangeException>(() => _service.GetSquare(0, 5, 7));
            Assert.Throws<ArgumentOutOfRangeException>(() => _service.GetSquare(40, -3, 7));
            Assert.Throws<ArgumentOutOfRangeException>(() => _service.GetSquare(40, 0, 7));
            Assert.Throws<ArgumentOutOfRangeException>(() => _service.GetSquare(4, 7, -2));
            Assert.Throws<ArgumentOutOfRangeException>(() => _service.GetSquare(4, 7, 0));
        }
    }
}