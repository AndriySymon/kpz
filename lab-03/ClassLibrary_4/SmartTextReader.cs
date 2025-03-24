using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_4
{
    public class SmartTextReader
    {
        public string FilePath { get; }

        public SmartTextReader(string filePath)
        {
            FilePath = filePath;
        }

        public string[][] ReadFile()
        {
            var lines = File.ReadAllLines(FilePath);
            var result = new string[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                result[i] = lines[i].ToCharArray().Select(c => c.ToString()).ToArray();
            }

            return result;
        }
    }
}
