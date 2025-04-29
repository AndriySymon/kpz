using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public class InactiveState : IElementState
    {
        public void Render(LightElementNode element)
        {
            Console.WriteLine($"Rendering inactive element: <{element.TagName}> (hidden)");
        }
    }
}
