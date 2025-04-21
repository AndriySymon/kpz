using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_classLibrary
{
    public class FinancialSupportHandler : SupportHandler
    {
        public FinancialSupportHandler(ILogger logger) : base("Фінансова підтримка", logger) { }

        protected override void InitializeSubCategories()
        {
            subCategories = new Dictionary<string, string>
        {
            { "1", "Помилка у рахунку" },
            { "2", "Повернення коштів" },
            { "3", "Тарифи та послуги" }
        };
        }

        public override void Handle(string request)
        {
            if (request == "2")
            {
                DisplaySubCategories();
                string sub = Console.ReadLine();
                if (sub == "0") return;

                if (subCategories.ContainsKey(sub))
                {
                    string response = "Ваш запит буде оброблений фінансовим спеціалістом найближчим часом.";
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
