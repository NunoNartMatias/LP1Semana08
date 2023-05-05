using System;

namespace GameUnits
{
    public class Program
    {
        private static void Main()
        {
            // Creating an array with 4 Units
            Unit[] _units = new Unit[]
            {
                // Giving values to created units
                new MilitaryUnit(5, 10, 15),
                new MilitaryUni(5, 3, 1),
                new MMilitaryUnit(3, 15, 8),
                new SettlerUnit(),
            };
        }
    }
}
