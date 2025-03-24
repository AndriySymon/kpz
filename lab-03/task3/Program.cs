using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_3;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRenderer vectorRenderer = new VectorRenderer();
            Shape circle1 = new Circle(vectorRenderer);
            circle1.Draw();

            Shape square1 = new Square(vectorRenderer);
            square1.Draw();

            Shape triangle1 = new Triangle(vectorRenderer);
            triangle1.Draw();

            IRenderer rasterRenderer = new RasterRenderer();
            Shape circle2 = new Circle(rasterRenderer);
            circle2.Draw();

            Shape square2 = new Square(rasterRenderer);
            square2.Draw();

            Shape triangle2 = new Triangle(rasterRenderer);
            triangle2.Draw();
        }
    }
}
