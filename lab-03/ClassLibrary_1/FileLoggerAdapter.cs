using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_1
{
    public class FileLoggerAdapter : Logger
    {
        private FileWriter fileWriter;

        public FileLoggerAdapter(string filePath)
        {
            fileWriter = new FileWriter(filePath);
        }

        public new void Log(string message)
        {
            fileWriter.WriteLine($"LOG: {message}");
        }

        public new void Error(string message)
        {
            fileWriter.WriteLine($"ERROR: {message}");
        }

        public new void Warn(string message)
        {
            fileWriter.WriteLine($"WARN: {message}");
        }
    }
}
