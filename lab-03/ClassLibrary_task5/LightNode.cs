using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public abstract class LightNode
    {
        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }

        public abstract void Accept(IElementVisitor visitor);

        public abstract ILightNodeIterator GetDepthFirstIterator();
        public abstract ILightNodeIterator GetBreadthFirstIterator();
    }
}
