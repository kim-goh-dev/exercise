using ShapeFactoryDemo.Shapes;

namespace ShapeFactoryDemo.Interfaces
{
    public interface IShapeFactory
    {
        public IShape GetShape(ShapeEnum shapeEnum);
    }
}
