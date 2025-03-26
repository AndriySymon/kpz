using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_5
{
    public class LightHTMLNode_task6
    {
        public static LightElementNode GetElementNode(string tagName, string displayType, bool isSelfClosing = false)
        {
            return new LightElementNode(tagName, displayType, isSelfClosing);
        }

        public static LightTextNode GetTextNode(string text)
        {
            return new LightTextNode(text);
        }
    }
}
