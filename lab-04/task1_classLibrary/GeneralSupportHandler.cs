using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_classLibrary
{
    public class GeneralSupportHandler : SupportHandler
    {
        public GeneralSupportHandler(ILogger logger) : base("Загальна підтримка", logger) { }

        protected override void InitializeSubCategories()
        {
            subCategories = new Dictionary<string, string>
        {
            { "1", "Часті питання" },
            { "2", "Робота компанії" }
        };
        }

        public override void Handle(string request)
        {
            if (request == "3")
            {
                DisplaySubCategories();
                string sub = Console.ReadLine();
                if (sub == "0") return;

                if (subCategories.ContainsKey(sub))
                {
                    string response = "Ваша інформація буде надіслана на електронну пошту.";
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
