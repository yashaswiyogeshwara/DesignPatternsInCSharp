using NullObjectPattern.Interfaces;
using NullObjectPattern.Models;
using System;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar gearCarA = new Car() { GearSystem = new FiveGearSystem(), Model = "GearModel1", RegNumber = "RegA" };

            ICar gearCarB = new Car() { GearSystem = new SixGearSystem(), Model = "GeaerModel2", RegNumber = "RegB" };
            // Here insted of sening a null for the GearSystem we are sending a NoGearSystem 
            // by which conditonals wont arise in GearSystemService class.
            ICar automaticCarX = new Car() { GearSystem = new NoGearSystem(), Model = "AutomaticModelX", RegNumber = "RegX" };

            GearSystemService gearSystemService = new GearSystemService();
            gearSystemService.PrintNumberOfGears(gearCarA);
            gearSystemService.PrintNumberOfGears(gearCarB);
            gearSystemService.PrintNumberOfGears(automaticCarX);
        }
    }
}
