using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Enemy
{
    public string Name { get; set; }
    public double Height { get; set; }
    public string Build { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Outfit { get; set; }
    public List<string> Inventory { get; set; }
    public List<string> EvilActs { get; set; }

    public Enemy()
    {
        Inventory = new List<string>();
        EvilActs = new List<string>();
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Enemy: {Name}");
        Console.WriteLine($"Height: {Height}m, Build: {Build}, Hair Color: {HairColor}, Eye Color: {EyeColor}");
        Console.WriteLine($"Outfit: {Outfit}");
        Console.WriteLine("Inventory: " + string.Join(", ", Inventory));
        Console.WriteLine("Evil Acts: " + string.Join(", ", EvilActs));
    }
}
public interface IEnemyBuilder
{
    IEnemyBuilder SetName(string name);
    IEnemyBuilder SetHeight(double height);
    IEnemyBuilder SetBuild(string build);
    IEnemyBuilder SetHairColor(string color);
    IEnemyBuilder SetEyeColor(string color);
    IEnemyBuilder SetOutfit(string outfit);
    IEnemyBuilder AddInventoryItem(string item);
    IEnemyBuilder AddEvilAct(string act);
    Enemy Build();
}
namespace ClassLibrary_task5
{
    public class EnemyBuilder : IEnemyBuilder
    {
        private Enemy _enemy = new Enemy();

        public IEnemyBuilder SetName(string name)
        {
            _enemy.Name = name;
            return this;
        }

        public IEnemyBuilder SetHeight(double height)
        {
            _enemy.Height = height;
            return this;
        }

        public IEnemyBuilder SetBuild(string build)
        {
            _enemy.Build = build;
            return this;
        }

        public IEnemyBuilder SetHairColor(string color)
        {
            _enemy.HairColor = color;
            return this;
        }

        public IEnemyBuilder SetEyeColor(string color)
        {
            _enemy.EyeColor = color;
            return this;
        }

        public IEnemyBuilder SetOutfit(string outfit)
        {
            _enemy.Outfit = outfit;
            return this;
        }

        public IEnemyBuilder AddInventoryItem(string item)
        {
            _enemy.Inventory.Add(item);
            return this;
        }

        public IEnemyBuilder AddEvilAct(string act)
        {
            _enemy.EvilActs.Add(act);
            return this;
        }

        public Enemy Build()
        {
            return _enemy;
        }
    }
}
