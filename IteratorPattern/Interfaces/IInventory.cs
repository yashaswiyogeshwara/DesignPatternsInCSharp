using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Interfaces
{
    public interface IInventory
    {
        public void AddItem(IInventoryItem item);
        public void RemoveItem(IInventoryItem item);
    }
}
