using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public class BreadthFirstIterator : ILightNodeIterator
    {
        private Queue<LightNode> queue = new Queue<LightNode>();

        public BreadthFirstIterator(LightNode root)
        {
            if (root != null)
                queue.Enqueue(root);
        }

        public bool HasNext()
        {
            return queue.Count > 0;
        }

        public LightNode Next()
        {
            var current = queue.Dequeue();

            if (current is LightElementNode element)
            {
                foreach (var child in element.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return current;
        }
    }
}
