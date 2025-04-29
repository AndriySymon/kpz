using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public string DisplayType { get; }
        public bool IsSelfClosing { get; }
        public List<string> CssClasses { get; }
        public List<LightNode> Children { get; }

        public LightElementNode(string tagName, string displayType, bool isSelfClosing = false)
        {
            TagName = tagName;
            DisplayType = displayType;
            IsSelfClosing = isSelfClosing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
        }

        public virtual void AddCssClass(string cssClass)
        {
            CssClasses.Add(cssClass);
        }

        public virtual void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public override string OuterHTML
        {
            get
            {
                var sb = new StringBuilder();

                sb.Append($"<{TagName}");

                if (CssClasses.Count > 0)
                {
                    sb.Append($" class=\"{string.Join(" ", CssClasses)}\"");
                }

                if (IsSelfClosing)
                {
                    sb.Append(" /");
                }

                sb.Append(">");

                sb.Append(InnerHTML);

                if (!IsSelfClosing)
                {
                    sb.Append($"</{TagName}>");
                }

                return sb.ToString();
            }
        }

        public override string InnerHTML
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var child in Children)
                {
                    sb.Append(child.OuterHTML);
                }
                return sb.ToString();
            }
        }
    }
}
