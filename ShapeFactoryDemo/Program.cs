using Microsoft.Extensions.DependencyInjection;
using ShapeFactoryDemo.Interfaces;
using ShapeFactoryDemo.Services;
using ShapeFactoryDemo.Shapes;

namespace ShapeFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddTransient<IShapeFactory, ShapeFactory>()
                .AddTransient<IShapeCalculationService, ShapeCalculationService>()
                .AddScoped<Sphere>()
                .AddScoped<IShape,Sphere>(s => s.GetService<Sphere>())
                .AddScoped<Cube>()
                .AddScoped<IShape, Cube>(s => s.GetService<Cube>())
                .BuildServiceProvider();

            //do the actual work here - shortcut
            var service = serviceProvider.GetService<IShapeCalculationService>();
            service.CalculateShapeMeasurements();
        }
    }
}
