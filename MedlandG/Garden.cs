using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedlandG
{
    /// <summary>
    /// Represents a garden in the household.
    /// </summary>
    public class Garden : IHouseholdArea
    {
        public List<string> Features { get; set; }

        public Garden()
        {
            Features = new List<string>();
        }

        public void AddFeature(string feature)
        {
            Features.Add(feature);
        }

        public void DescribeArea()
        {
            Console.WriteLine("Garden with features:");
            foreach (var feature in Features)
            {
                Console.WriteLine($"- {feature}");
            }
        }
    }
}
