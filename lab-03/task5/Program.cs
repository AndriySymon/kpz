using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_task5;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var div = new LifecycleElementNode("div", "block");
            div.AddCssClass("container");

            var p1 = new LifecycleElementNode("p", "block");
            p1.AddCssClass("paragraph");
            p1.AddChild(new LightTextNode("This is the first paragraph."));

            var p2 = new LifecycleElementNode("p", "block");
            p2.AddCssClass("paragraph");
            p2.AddChild(new LightTextNode("This is the second paragraph."));

            div.AddChild(p1);
            div.AddChild(p2);
            var ul = new LifecycleElementNode("ul", "block");
            ul.AddCssClass("list");

            var li1 = new LifecycleElementNode("li", "block");
            li1.AddChild(new LightTextNode("Item 1"));

            var li2 = new LifecycleElementNode("li", "block");
            li2.AddChild(new LightTextNode("Item 2"));

            ul.AddChild(li1);
            ul.AddChild(li2);

            Console.WriteLine(div.OuterHTML);
            Console.WriteLine(ul.OuterHTML);

            Console.WriteLine("\n--- Depth First Traversal ---");
            var dfs = div.GetDepthFirstIterator();
            while (dfs.HasNext())
            {
                var node = dfs.Next();
                Console.WriteLine(node.OuterHTML);
            }

            Console.WriteLine("\n--- Breadth First Traversal ---");
            var bfs = div.GetBreadthFirstIterator();
            while (bfs.HasNext())
            {
                var node = bfs.Next();
                Console.WriteLine(node.OuterHTML);
            }

            Console.WriteLine("\n--- Command Pattern: Change Text ---");
            var changeTextCommand = new ChangeTextCommand((LightTextNode)p1.Children[0], "This is the modified first paragraph.");
            changeTextCommand.Execute();
            Console.WriteLine(p1.OuterHTML);

            Console.WriteLine("\n--- State Pattern ---");
            p1.SetState(new InactiveState());
            p2.SetState(new ActiveState());

            Console.WriteLine("Rendering elements with state:");
            div.Render();
            p1.Render();
            p2.Render();
        }
    }
}
