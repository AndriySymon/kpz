using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1_classLibrary;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();

            var tech = new TechnicalSupportHandler(logger);
            var finance = new FinancialSupportHandler(logger);
            var general = new GeneralSupportHandler(logger);
            var complaints = new ComplaintSupportHandler(logger);
            var appSupport = new MobileAppSupportHandler(logger);
            var security = new SecuritySupportHandler(logger);

            tech.SetNext(finance);
            finance.SetNext(general);
            general.SetNext(complaints);
            complaints.SetNext(appSupport);
            appSupport.SetNext(security);

            while (true)
            {
                tech.DisplayMenu();
                string input = Console.ReadLine();
                if (input == "0") break;

                tech.Handle(input);
                Console.Clear();
            }

            Console.WriteLine("\nДякуємо, що звернулись до служби підтримки!");
        }
    }
}
