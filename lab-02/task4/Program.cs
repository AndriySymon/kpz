using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public class Virus : ICloneable
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(string name, string species, double weight, int age)
        {
            Name = name;
            Species = species;
            Weight = weight;
            Age = age;
            Children = new List<Virus>();
        }

        public object Clone()
        {
            Virus clonedVirus = (Virus)this.MemberwiseClone();
            clonedVirus.Children = new List<Virus>();
            foreach (var child in this.Children)
            {
                clonedVirus.Children.Add((Virus)child.Clone());
            }
            return clonedVirus;
        }

        public void AddChild(Virus childVirus)
        {
            Children.Add(childVirus);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Species: {Species}, Weight: {Weight}, Age: {Age}, Children Count: {Children.Count}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Virus grandParent = new Virus("GrandParentVirus", "TypeA", 1.5, 5);
            Virus parent1 = new Virus("Parent1Virus", "TypeB", 1.2, 3);
            Virus parent2 = new Virus("Parent2Virus", "TypeB", 1.3, 4);
            Virus child1 = new Virus("Child1Virus", "TypeC", 0.5, 1);
            Virus child2 = new Virus("Child2Virus", "TypeC", 0.4, 1);

            parent1.AddChild(child1);
            parent2.AddChild(child2);

            grandParent.AddChild(parent1);
            grandParent.AddChild(parent2);

            Virus clonedGrandParent = (Virus)grandParent.Clone();

            Console.WriteLine("Original GrandParent Virus:");
            Console.WriteLine(grandParent);

            Console.WriteLine("\nCloned GrandParent Virus:");
            Console.WriteLine(clonedGrandParent);

            Console.WriteLine("\nChildren of Original GrandParent Virus:");
            foreach (var child in grandParent.Children)
            {
                Console.WriteLine(child);
            }

            Console.WriteLine("\nChildren of Cloned GrandParent Virus:");
            foreach (var child in clonedGrandParent.Children)
            {
                Console.WriteLine(child);
            }
        }
    }
}
