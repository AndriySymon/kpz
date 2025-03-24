using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_5
{
    public class LightHTMLNode_task6
    {
        private static Dictionary<string, LightElementNode> elementCache = new Dictionary<string, LightElementNode>();

        public static LightElementNode GetElementNode(string tagName, string displayType, bool isSelfClosing = false)
        {
            string key = $"{tagName}-{displayType}-{isSelfClosing}";
            if (!elementCache.ContainsKey(key))
            {
                elementCache[key] = new LightElementNode(tagName, displayType, isSelfClosing);
            }
            return elementCache[key];
        }

        public static LightTextNode GetTextNode(string text)
        {
            return new LightTextNode(text);
        }
    }
}
