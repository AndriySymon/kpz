using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public abstract class LightElementNodeWithLifecycle : LightElementNode
    {
        public LightElementNodeWithLifecycle(string tagName, string displayType, bool isSelfClosing = false)
            : base(tagName, displayType, isSelfClosing)
        {
            OnCreated();
        }

        public override void AddCssClass(string cssClass)
        {
            base.AddCssClass(cssClass);
            OnClassListApplied();
        }

        public override void AddChild(LightNode child)
        {
            base.AddChild(child);
            OnInserted();
        }

        public override string OuterHTML
        {
            get
            {
                OnTextRendered();
                return base.OuterHTML;
            }
        }

        protected virtual void OnCreated() { }
        protected virtual void OnInserted() { }
        protected virtual void OnRemoved() { }
        protected virtual void OnStylesApplied() { }
        protected virtual void OnClassListApplied() { }
        protected virtual void OnTextRendered() { }
    }
}
