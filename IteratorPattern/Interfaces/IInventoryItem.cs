using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Interfaces
{
    public interface IInventoryItem
    {
        public Guid Id { get; set; }
        public string Label { get; set; }
        public int LocationId { get; set; }
    }
}
