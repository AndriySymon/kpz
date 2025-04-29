using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public class ActiveState : IElementState
    {
        public void Render(LightElementNode element)
        {
            Console.WriteLine($"Rendering active element: <{element.TagName}>");
        }
    }

}
