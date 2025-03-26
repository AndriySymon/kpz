using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_5
{
    public class LightHTMLNodeFactory
    {
        private Dictionary<string, LightElementNode> nodesCache = new Dictionary<string, LightElementNode>();

        public LightElementNode GetElementPrototype(string tagName, string displayType, bool isSelfClosing = false)
        {
            string key = tagName + displayType + isSelfClosing;
            if (!nodesCache.ContainsKey(key))
            {
                nodesCache[key] = new LightElementNode(tagName, displayType, isSelfClosing);
            }
            return nodesCache[key];
        }
    }
}
