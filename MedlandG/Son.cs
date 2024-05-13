using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedlandG
{
    /// <summary>
    /// Represents a son in the household.
    /// </summary>
    internal class Son : Person
    {
        public Son(string name, int age) : base(name, age) { }

        public override void Describe()
        {
            Console.WriteLine($"Son: {Name}, Age: {Age}");
        }
    }
}
