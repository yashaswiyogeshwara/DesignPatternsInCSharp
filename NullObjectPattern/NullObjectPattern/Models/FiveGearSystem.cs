using NullObjectPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Models
{
    public class FiveGearSystem : IGearSystem
    {
        public int NumberOfGear { get { return 5; } set { } }
    }
}
