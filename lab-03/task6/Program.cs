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
            LightHTMLNodeFactory nodeFactory = new LightHTMLNodeFactory();

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string tag;

                if (i == 0)
                {
                    tag = "h1";
                }
                else if (line.Length < 20)
                {
                    tag = "h2";
                }
                else if (line.StartsWith(" "))
                {
                    tag = "blockquote";
                }
                else
                {
                    tag = "p";
                }

                LightElementNode elementNode = new LightElementNode(tag, "block", false);
                elementNode.AddChild(new LightTextNode(line));
                htmlNodes.Add(elementNode);
            }

            foreach (var node in htmlNodes)
            {
                Console.WriteLine(node.OuterHTML);
            }

            long memoryUsage = GC.GetTotalMemory(true);
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
