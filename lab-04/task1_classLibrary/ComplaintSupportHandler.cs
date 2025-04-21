using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_classLibrary
{
    public class ComplaintSupportHandler : SupportHandler
    {
        public ComplaintSupportHandler(ILogger logger) : base("Служба скарг", logger) { }

        protected override void InitializeSubCategories()
        {
            subCategories = new Dictionary<string, string>
        {
            { "1", "Якість обслуговування" },
            { "2", "Порушення строків" },
            { "3", "Неввічлива поведінка" }
        };
        }

        public override void Handle(string request)
        {
            if (request == "4")
            {
                DisplaySubCategories();
                string sub = Console.ReadLine();
                if (sub == "0") return;

                if (subCategories.ContainsKey(sub))
                {
                    string response = "Дякуємо за вашу скаргу. Ми розглянемо її протягом 24 годин.";
                    LogAndDisplayResponse(handlerName, subCategories[sub], response);
                }
            }
            else
            {
                nextHandler?.Handle(request);
            }
        }
    }

}
