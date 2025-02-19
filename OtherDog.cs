using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IinterfacesAndAbstractClasses
{
    internal class OtherDog : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public string Height { get; set; }
        public int Age { get; set; }

        public OtherDog(string name, string colour, string height, int age)
        {
            Name = name;
            Colour = colour;
            Height = height;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public string Cry()
        {
            return "Woof!";
        }
    }
}