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
        private IElementState _state;

        public LightElementNode(string tagName, string displayType, bool isSelfClosing = false)
        {
            TagName = tagName;
            DisplayType = displayType;
            IsSelfClosing = isSelfClosing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
            _state = new ActiveState();
        }

        public virtual void AddCssClass(string cssClass)
        {
            CssClasses.Add(cssClass);
        }

        public virtual void AddChild(LightNode child)
        {
            Children.Add(child);
        }
        public void SetState(IElementState state)
        {
            _state = state;
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

        public override ILightNodeIterator GetDepthFirstIterator()
        {
            return new DepthFirstIterator(this);
        }

        public override ILightNodeIterator GetBreadthFirstIterator()
        {
            return new BreadthFirstIterator(this);
        }

        public void Render()
        {
            _state.Render(this);
        }
        public override void Accept(IElementVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
