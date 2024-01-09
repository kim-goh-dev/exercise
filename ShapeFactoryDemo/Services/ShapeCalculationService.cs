using ShapeFactoryDemo.Interfaces;
using ShapeFactoryDemo.Shapes;
using System;

namespace ShapeFactoryDemo.Services
{
    public class ShapeCalculationService : IShapeCalculationService
    {
        private readonly IShapeFactory _shapeFactory;
        private IShape _shape;

        public ShapeCalculationService(IShapeFactory shapeFactory)
        {
            _shapeFactory = shapeFactory;
        }

        public void CalculateShapeMeasurements()
        {
            _shape = GetShapeFromUser();

            _shape.GetInputValues();

            _shape.DisplaySurfaceArea();

            _shape.DisplayVolume();
        }

        private IShape GetShapeFromUser()
        {
            Console.WriteLine("Enter the serial no. for the shape you want to choose :");
            Console.WriteLine("1. Cube");
            Console.WriteLine("2. Sphere");
            var serialNumber = int.Parse(Console.ReadLine());


            return GetShape(serialNumber);
        }

        // testing out pattern matching
        private IShape GetShape(int serialNumber) => serialNumber switch
        {
            1 => _shapeFactory.GetShape(ShapeEnum.Cube),
            2 => _shapeFactory.GetShape(ShapeEnum.Sphere),
            _ => throw new ArgumentOutOfRangeException("Invalid input.")
        };
    }


}
