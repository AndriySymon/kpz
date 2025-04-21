using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task1_classLibrary
{
    public abstract class SupportHandler
    {
        protected SupportHandler nextHandler;
        protected readonly ILogger Logger;
        protected readonly string handlerName;
        protected Dictionary<string, string> subCategories;

        public SupportHandler(string name, ILogger logger)
        {
            handlerName = name;
            Logger = logger;
            InitializeSubCategories();
        }

        public void SetNext(SupportHandler handler)
        {
            nextHandler = handler;
        }

        public virtual void DisplayMenu()
        {
            Console.WriteLine($"\n=== Меню підтримки ===");
            Console.WriteLine("1. Технічні проблеми");
            Console.WriteLine("2. Фінансові питання");
            Console.WriteLine("3. Загальні питання");
            Console.WriteLine("4. Скарги");
            Console.WriteLine("5. Проблеми з мобільним додатком");
            Console.WriteLine("6. Питання безпеки");
            Console.WriteLine("0. Вийти");
            Console.Write("Оберіть опцію: ");
        }

        public abstract void Handle(string request);
        protected abstract void InitializeSubCategories();

        protected void DisplaySubCategories()
        {
            Console.WriteLine($"\n=== {handlerName} ===");
            foreach (var pair in subCategories)
            {
                Console.WriteLine($"{pair.Key}. {pair.Value}");
            }
            Console.WriteLine("0. Назад");
            Console.Write("Оберіть підкатегорію: ");
        }

        protected void ShowProcessing()
        {
            Console.Write("Обробка запиту");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(300);
                Console.Write(".");
            }
            Console.WriteLine();
        }

        protected void LogAndDisplayResponse(string category, string subcategory, string response)
        {
            ShowProcessing();
            Console.WriteLine("\n" + response);
            Logger.Log($"Оброблено запит: {category} - {subcategory}");

            Console.WriteLine("\nНатисніть будь-яку клавішу для продовження...");
            Console.ReadKey();
        }
    }

}
