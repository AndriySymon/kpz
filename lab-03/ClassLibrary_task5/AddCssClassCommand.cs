using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public class AddCssClassCommand : ICommand
    {
        private readonly LightElementNode _element;
        private readonly string _cssClass;

        public AddCssClassCommand(LightElementNode element, string cssClass)
        {
            _element = element;
            _cssClass = cssClass;
        }

        public void Execute()
        {
            _element.AddCssClass(_cssClass);
        }
    }
}
