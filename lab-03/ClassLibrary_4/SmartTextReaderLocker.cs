using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary_4
{
    public class SmartTextReaderLocker : SmartTextReader
    {
        private Regex _regex;

        public SmartTextReaderLocker(string filePath, string pattern) : base(filePath)
        {
            _regex = new Regex(pattern);
        }

        public new string[][] ReadFile()
        {
            if (_regex.IsMatch(FilePath))
            {
                Console.WriteLine("Access denied!");
                return new string[0][];
            }

            return base.ReadFile();
        }
    }
}
