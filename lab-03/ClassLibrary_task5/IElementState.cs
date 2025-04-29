using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public interface IElementState
    {
        void Render(LightElementNode element);
    }
}
