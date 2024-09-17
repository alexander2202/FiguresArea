namespace GeometryLib
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class ShapeAreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
