using System;
using ShapeFactoryDemo.Interfaces;
using ShapeFactoryDemo.Shapes;

namespace ShapeFactoryDemo
{
    public class ShapeFactory : IShapeFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public ShapeFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        // trying out pattern matching again
        public IShape GetShape(ShapeEnum shapeEnum) => shapeEnum switch
        {
            ShapeEnum.Cube => (IShape)_serviceProvider.GetService(typeof(Cube)),
            ShapeEnum.Sphere => (IShape)_serviceProvider.GetService(typeof(Sphere)),
            _ => throw new ArgumentOutOfRangeException(nameof(shapeEnum), shapeEnum, $"Shape of {shapeEnum} is not supported.")
        };
    }
}
