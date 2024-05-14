namespace MedlandG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create household
            Household household = new Household();

            // Add occupant
            household.AddOccupant(new Parent("Colin", 61));
            household.AddOccupant(new Parent("Aly", 58));
            household.AddOccupant(new Son("Kieran", 29));

            // Add rooms and areas
            household.AddArea(new Room("Parent's Bedroom", true));
            household.AddArea(new Room("Son's Bedroom", true));
            household.AddArea(new Room("Vacant Bedroom 1", false));
            household.AddArea(new Room("Vacant Bedroom 2", false));
            household.AddArea(new Bathroom(true)); // En-suite bathroom
            household.AddArea(new Bathroom(false)); // Shared bathroom
            household.AddArea(new Room("Toilet", false));
            household.AddArea(new Room("Lounge", false));
            household.AddArea(new Room("Kitchen", false));
            household.AddArea(new Room("Utility Room", false));
            household.AddArea(new Room("Study", false));
            household.AddArea(new Room("Dining Room", false));

            // Add garden with features
            Garden garden = new Garden();
            garden.AddFeature("Shed");
            garden.AddFeature("Patio");
            garden.AddFeature("Greenhouse");
            garden.AddFeature("Sun Loungers");
            garden.AddFeature("Fruit Plants");

            household.AddArea(garden);

            // Describe household
            household.DescribeHousehold();
        }
    }
}
