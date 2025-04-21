using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_classLibrary
{
    public class SecuritySupportHandler : SupportHandler
    {
        public SecuritySupportHandler(ILogger logger) : base("Питання безпеки", logger) { }

        protected override void InitializeSubCategories()
        {
            subCategories = new Dictionary<string, string>
        {
            { "1", "Підозріла активність" },
            { "2", "Зміна паролю" },
            { "3", "Двохфакторна аутентифікація" }
        };
        }

        public override void Handle(string request)
        {
            if (request == "6")
            {
                DisplaySubCategories();
                string sub = Console.ReadLine();
                if (sub == "0") return;

                if (subCategories.ContainsKey(sub))
                {
                    string response = "Ваші дані захищені. Фахівець зв'яжеться з вами за потреби.";
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
