using NullObjectPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Models
{
    public class Car : ICar
    {
        public string Model { get; set; }
        public IGearSystem GearSystem { get; set; }
        public string RegNumber { get; set; }
    }
}
