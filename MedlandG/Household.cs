using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedlandG
{
    public class Household
    {
        public List<Person> Occupants { get; private set; }
        public List<IHouseholdArea> Areas { get; private set; }

        public Household()
        {
            Occupants = new List<Person>();
            Areas = new List<IHouseholdArea>();
        }

        public void AddOccupant(Person person)
        {
            Occupants.Add(person);
        }

        public void AddArea(IHouseholdArea area)
        {
            Areas.Add(area);
        }

        public void DescribeHousehold()
        {
            Console.WriteLine("Household Description:");

            Console.WriteLine("Occupants:");
            foreach(var occupant in Occupants)
            {
                occupant.Describe();
            }

            Console.WriteLine("Areas:");
            foreach(var area in Areas)
            {
                area.DescribeArea();
            }
        }
    }
}
