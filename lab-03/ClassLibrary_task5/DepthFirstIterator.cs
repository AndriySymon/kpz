using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public class DepthFirstIterator : ILightNodeIterator
    {
        private Stack<LightNode> stack = new Stack<LightNode>();

        public DepthFirstIterator(LightNode root)
        {
            if (root != null)
                stack.Push(root);
        }

        public bool HasNext()
        {
            return stack.Count > 0;
        }

        public LightNode Next()
        {
            var current = stack.Pop();

            if (current is LightElementNode element)
            {
                for (int i = element.Children.Count - 1; i >= 0; i--)
                {
                    stack.Push(element.Children[i]);
                }
            }

            return current;
        }
    }
}
