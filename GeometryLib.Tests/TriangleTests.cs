using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ValidSides_ReturnsCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);
            var area = triangle.CalculateArea();
            Assert.Equal(6, area);
        }

        [Fact]
        public void Triangle_IsRightAngled_ValidRightTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightAngled());
        }

        [Fact]
        public void Triangle_Constructor_NegativeSides_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 1, 1));
        }

        [Fact]
        public void Triangle_Constructor_InvalidTriangle_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
        }
    }
}
