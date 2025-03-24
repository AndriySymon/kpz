using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_4;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath1 = "textFile.txt";
            string filePath2 = "restrictedFile.txt";
            SmartTextReaderLocker lockedReader = new SmartTextReaderLocker(filePath1, "restrictedFile.txt");
            lockedReader.ReadFile();
            SmartTextChecker checkedReader = new SmartTextChecker(filePath1);
            var content = checkedReader.ReadFile();
            Console.WriteLine("\nContent of the file:");
            foreach (var line in content)
            {
                Console.WriteLine(string.Join("", line));
            }
        }
    }
}
