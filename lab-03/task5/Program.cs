using System;
using ClassLibrary_task5;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var div = new LightElementNode("div", "block");
            div.AddCssClass("container");

            var p1 = new LightElementNode("p", "block");
            p1.AddCssClass("paragraph");
            p1.AddChild(new LightTextNode("This is the first paragraph."));
            p1.AddEventListener("click", () => Console.WriteLine("Paragraph 1 clicked!"));

            var p2 = new LightElementNode("p", "block");
            p2.AddCssClass("paragraph");
            p2.AddChild(new LightTextNode("This is the second paragraph."));
            p2.AddEventListener("mouseover", () => Console.WriteLine("Paragraph 2 hovered!"));

            div.AddChild(p1);
            div.AddChild(p2);

            var ul = new LightElementNode("ul", "block");
            ul.AddCssClass("list");

            var li1 = new LightElementNode("li", "block");
            li1.AddChild(new LightTextNode("Item 1"));

            var li2 = new LightElementNode("li", "block");
            li2.AddChild(new LightTextNode("Item 2"));

            ul.AddChild(li1);
            ul.AddChild(li2);

            div.AddChild(ul);

            var localImage = new LightImageNode("C:/FELV-cat.jpg", new FileImageLoader());
            var webImage = new LightImageNode("https://www.alleycat.org/wp-content/uploads/2019/03/FELV-cat.jpg", new NetworkImageLoader());

            div.AddChild(localImage);
            div.AddChild(webImage);

            Console.WriteLine("\n--- OuterHTML ---");
            Console.WriteLine(div.OuterHTML);

            Console.WriteLine("\n--- InnerHTML (Image Load) ---");
            Console.WriteLine(localImage.InnerHTML);
            Console.WriteLine(webImage.InnerHTML);

            Console.WriteLine("\n--- Симуляція подій ---");
            p1.TriggerEvent("click");
            p2.TriggerEvent("mouseover");

            Console.ReadKey();
        }
    }
}
