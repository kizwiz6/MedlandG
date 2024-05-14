using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedlandG
{
    /// <summary>
    /// Represents a bathroom in the household.
    /// </summary>
    internal class Bathroom : IHouseholdArea
    {
        public bool IsEnsuite { get; set; }

        public Bathroom(bool isEnsuite)
        {
            IsEnsuite = isEnsuite;
        }

        public void DescribeArea()
        {
            Console.WriteLine($"Bathroom (En-Suite: {IsEnsuite}");
        }
    }
}
