using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IinterfacesAndAbstractClasses
{
    internal abstract class Animal
    {
        internal string Name { get; set; }
        internal string Colour { get; set; }
        internal int Age { get; set; }

        internal Animal(string name, string colour, int age)
        {
            Name = name;
            Colour = colour;
            Age = age;
        }

        internal abstract void Eat();

    }
}