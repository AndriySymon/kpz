using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_1;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger consoleLogger = new Logger();
            consoleLogger.Log("Це звичайне повiдомлення");
            consoleLogger.Error("Це повiдомлення про помилку");
            consoleLogger.Warn("Це попередження");

            FileLoggerAdapter fileLogger = new FileLoggerAdapter("log.txt");
            fileLogger.Log("Файловий лог - звичайне повідомлення");
            fileLogger.Error("Файловий лог - помилка");
            fileLogger.Warn("Файловий лог - попередження");
        }
    }
}
