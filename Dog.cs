using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IinterfacesAndAbstractClasses
{
    internal class Dog : Animal
    {

        internal Dog(string name, string colour, int age) : base(name, colour, age) { }
        
        internal override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
    }
}