using NullObjectPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    public class GearSystemService
    {
        public void PrintNumberOfGears(ICar car) {
            Console.WriteLine(car.GearSystem.NumberOfGear);     
        }
    }
}
