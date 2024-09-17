namespace GeometryLib.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ValidRadius_ReturnsCorrectArea()
        {
            var circle = new Circle(3);
            var area = circle.CalculateArea();
            Assert.Equal(28.274333882308138, area, 5);
        }

        [Fact]
        public void Circle_Constructor_NegativeRadius_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}