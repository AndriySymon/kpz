using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_5;

namespace task6
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
            string bookText = await DownloadBookText(url);

            string[] lines = bookText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            List<LightNode> htmlNodes = new List<LightNode>();

            foreach (var line in lines)
            {
                LightElementNode elementNode = null;

                if (line == lines[0])
                {
                    elementNode = LightHTMLNode_task6.GetElementNode("h1", "block");
                }
                else if (line.Length < 20)
                {
                    elementNode = LightHTMLNode_task6.GetElementNode("h2", "block");
                }
                else if (line.StartsWith(" "))
                {
                    elementNode = LightHTMLNode_task6.GetElementNode("blockquote", "block");
                }
                else
                {
                    elementNode = LightHTMLNode_task6.GetElementNode("p", "block");
                }

                elementNode.AddChild(LightHTMLNode_task6.GetTextNode(line));
                htmlNodes.Add(elementNode);
            }

            foreach (var node in htmlNodes)
            {
                Console.WriteLine(node.OuterHTML);
            }

            long memoryUsage = System.GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used by the HTML tree: {memoryUsage} bytes");
        }

        static async Task<string> DownloadBookText(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }
    }
}
