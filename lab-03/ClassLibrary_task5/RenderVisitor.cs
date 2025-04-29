using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public class RenderVisitor : IElementVisitor
    {
        public void Visit(LightElementNode element)
        {
            Console.WriteLine($"Rendering element: <{element.TagName}>");
            foreach (var child in element.Children)
            {
                child.Accept(this);
            }
        }

        public void Visit(LightTextNode textNode)
        {
            Console.WriteLine($"Rendering text: {textNode.Text}");
        }
    }

}
