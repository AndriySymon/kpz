using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_3
{
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle() => Console.WriteLine("Drawing Circle as pixels");
        public void RenderSquare() => Console.WriteLine("Drawing Square as pixels");
        public void RenderTriangle() => Console.WriteLine("Drawing Triangle as pixels");
    }
}
