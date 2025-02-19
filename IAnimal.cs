using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IinterfacesAndAbstractClasses
{
    internal interface IAnimal
    {
        string Name { get; set; }
        string Colour { get; set; }
        string Height { get; set; }
        int Age { get; set; }

        abstract void Eat();
        string Cry();
    }
}