using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_5
{
    public class LightElementNode : LightNode
    {
        private string tagName;
        private string displayType;
        private bool isSelfClosing;
        private List<LightNode> children = new List<LightNode>();

        public LightElementNode(string tagName, string displayType, bool isSelfClosing = false)
        {
            this.tagName = tagName;
            this.displayType = displayType;
            this.isSelfClosing = isSelfClosing;
        }

        public void AddChild(LightNode child)
        {
            children.Add(child);
        }

        public override string OuterHTML => isSelfClosing ? $"<{tagName} />" : $"<{tagName}>{string.Join("", children.Select(c => c.OuterHTML))}</{tagName}>";
    }
}
