using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Hero
{
    public string Name { get; set; }
    public double Height { get; set; }
    public string Build { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Outfit { get; set; }
    public List<string> Inventory { get; set; }
    public List<string> GoodDeeds { get; set; }

    public Hero()
    {
        Inventory = new List<string>();
        GoodDeeds = new List<string>();
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Hero: {Name}");
        Console.WriteLine($"Height: {Height}m, Build: {Build}, Hair Color: {HairColor}, Eye Color: {EyeColor}");
        Console.WriteLine($"Outfit: {Outfit}");
        Console.WriteLine("Inventory: " + string.Join(", ", Inventory));
        Console.WriteLine("Good Deeds: " + string.Join(", ", GoodDeeds));
    }
}
public interface IHeroBuilder
{
    IHeroBuilder SetName(string name);
    IHeroBuilder SetHeight(double height);
    IHeroBuilder SetBuild(string build);
    IHeroBuilder SetHairColor(string color);
    IHeroBuilder SetEyeColor(string color);
    IHeroBuilder SetOutfit(string outfit);
    IHeroBuilder AddInventoryItem(string item);
    IHeroBuilder AddGoodDeed(string deed);
    Hero Build();
}

namespace ClassLibrary_task5
{
    public class HeroBuilder : IHeroBuilder
    {
        private Hero _hero = new Hero();

        public IHeroBuilder SetName(string name)
        {
            _hero.Name = name;
            return this;
        }

        public IHeroBuilder SetHeight(double height)
        {
            _hero.Height = height;
            return this;
        }

        public IHeroBuilder SetBuild(string build)
        {
            _hero.Build = build;
            return this;
        }

        public IHeroBuilder SetHairColor(string color)
        {
            _hero.HairColor = color;
            return this;
        }

        public IHeroBuilder SetEyeColor(string color)
        {
            _hero.EyeColor = color;
            return this;
        }

        public IHeroBuilder SetOutfit(string outfit)
        {
            _hero.Outfit = outfit;
            return this;
        }

        public IHeroBuilder AddInventoryItem(string item)
        {
            _hero.Inventory.Add(item);
            return this;
        }

        public IHeroBuilder AddGoodDeed(string deed)
        {
            _hero.GoodDeeds.Add(deed);
            return this;
        }

        public Hero Build()
        {
            return _hero;
        }
    }
}
