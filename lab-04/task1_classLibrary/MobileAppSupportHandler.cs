using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_classLibrary
{
    public class MobileAppSupportHandler : SupportHandler
    {
        public MobileAppSupportHandler(ILogger logger) : base("Підтримка мобільного додатку", logger) { }

        protected override void InitializeSubCategories()
        {
            subCategories = new Dictionary<string, string>
        {
            { "1", "Краші додатку" },
            { "2", "Проблеми з авторизацією" },
            { "3", "Функціональні баги" }
        };
        }

        public override void Handle(string request)
        {
            if (request == "5")
            {
                DisplaySubCategories();
                string sub = Console.ReadLine();
                if (sub == "0") return;

                if (subCategories.ContainsKey(sub))
                {
                    string response = "Ми працюємо над виправленням. Очікуйте оновлення додатку.";
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
