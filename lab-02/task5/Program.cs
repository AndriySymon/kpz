using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_task5;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            HeroBuilder heroBuilder = new HeroBuilder();
            Hero hero = director.BuildHero(heroBuilder);

            EnemyBuilder enemyBuilder = new EnemyBuilder();
            Enemy enemy = director.BuildEnemy(enemyBuilder);

            Console.WriteLine("Hero Information:");
            hero.ShowInfo();

            Console.WriteLine("\nEnemy Information:");
            enemy.ShowInfo();
        }
    }
}
