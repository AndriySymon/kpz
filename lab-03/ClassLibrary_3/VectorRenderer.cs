using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_3
{
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle() => Console.WriteLine("Drawing Circle as vector graphics");
        public void RenderSquare() => Console.WriteLine("Drawing Square as vector graphics");
        public void RenderTriangle() => Console.WriteLine("Drawing Triangle as vector graphics");
    }
}
