using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_classLibrary
{
    public class TechnicalSupportHandler : SupportHandler
    {
        public TechnicalSupportHandler(ILogger logger) : base("Технічна підтримка", logger) { }

        protected override void InitializeSubCategories()
        {
            subCategories = new Dictionary<string, string>
        {
            { "1", "Проблеми з інтернетом" },
            { "2", "Налаштування обладнання" },
            { "3", "Оновлення ПЗ" },
            { "4", "Пошта" }
        };
        }

        public override void Handle(string request)
        {
            if (request == "1")
            {
                DisplaySubCategories();
                string sub = Console.ReadLine();
                if (sub == "0") return;

                if (subCategories.ContainsKey(sub))
                {
                    string response;
                    if (sub == "1")
                        response = "Інженер з мережевих питань зв'яжеться з вами протягом 1 години.";
                    else if (sub == "2")
                        response = "Майстер прибуде до вас протягом 3 годин.";
                    else if (sub == "3")
                        response = "Оновлення буде виконано автоматично.";
                    else if (sub == "4")
                        response = "Перевірте налаштування IMAP/SMTP або зачекайте.";
                    else
                        response = "Очікуйте на зв'язок з оператором.";

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
