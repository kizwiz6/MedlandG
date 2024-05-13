using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedlandG
{
    /// <summary>
    /// Represents a parent in the houseold.
    /// </summary>
    public class Parent : Person
    {
        public Parent(string name, int age) : base(name, age) { }
        public override void Describe()
        {
            Console.WriteLine($"Parent: {Name}, Age: {Age}");
        }
    }
}
