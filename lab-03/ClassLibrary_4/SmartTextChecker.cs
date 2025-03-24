using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_4
{
    public class SmartTextChecker : SmartTextReader
    {
        public SmartTextChecker(string filePath) : base(filePath) { }

        public new string[][] ReadFile()
        {
            try
            {
                Console.WriteLine($"Opening file: {FilePath}");
                var content = base.ReadFile();

                int lineCount = content.Length;
                int charCount = 0;
                foreach (var line in content)
                {
                    charCount += line.Length;
                }

                Console.WriteLine($"File read successfully. {lineCount} lines and {charCount} characters.");
                return content;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                throw;
            }
            finally
            {
                Console.WriteLine($"File {FilePath} closed.");
            }
        }
    }
}
