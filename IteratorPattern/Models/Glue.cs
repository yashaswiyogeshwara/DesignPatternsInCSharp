using IteratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Models
{
    public class Glue : IInventoryItem
    {
        public Guid Id { get; set; }
        public string Label { get; set; }
        public int LocationId { get; set; }
        public string CompanyName { get; set; }
    }
}
