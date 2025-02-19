using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IinterfacesAndAbstractClasses
{
    internal class OtherCat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public string Height { get; set; }
        public int Age { get; set; }

        public OtherCat(string name, string colour, string height, int age)
        {
            Name = name;
            Colour = colour;
            Height = height;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }

        public string Cry()
        {
            return "Meow!";
        }
    }
}