using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5_classLibrary;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doc = new TextDocument();
            var editor = new TextEditor(doc);

            editor.Write("Hello, world!");
            editor.Print(); 

            editor.Write("This is a new version.");
            editor.Print();

            editor.Undo();
            editor.Print();

            editor.Undo();
            editor.Print();

            editor.Undo();
        }
    }
}
