using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedlandG
{
    /// <summary>
    /// Represents a room in the household.
    /// </summary>
    public class Room : IHouseholdArea
    {
        public string Name { get; set; }
        public bool IsOccupied { get; set; }

        public Room(string name, bool isOccupied)
        {
            Name = name;
            IsOccupied = isOccupied;
        }

        public void DescribeArea()
        {
            Console.WriteLine($"{Name} (Occupied: {IsOccupied}");
        }
    }
}
