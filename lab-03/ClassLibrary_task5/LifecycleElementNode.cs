using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public class LifecycleElementNode : LightElementNodeWithLifecycle
    {
        public LifecycleElementNode(string tagName, string displayType, bool isSelfClosing = false)
            : base(tagName, displayType, isSelfClosing) { }

        protected override void OnCreated()
        {
            Console.WriteLine($"[{TagName}] Created");
        }

        protected override void OnInserted()
        {
            Console.WriteLine($"[{TagName}] Child Inserted");
        }

        protected override void OnClassListApplied()
        {
            Console.WriteLine($"[{TagName}] Class List Applied");
        }

        protected override void OnTextRendered()
        {
            Console.WriteLine($"[{TagName}] Text Rendered");
        }
    }
}
