using IteratorPattern.Interfaces;
using IteratorPattern.Iterators;
using IteratorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Inventory
{
    public class DoorInventory : IInventory, IIterable
    {
        private List<Door> DoorCollection = new List<Door>();
        public DoorInventory(ISeeder<Door> seeder) 
        {
            seeder.SeedData(this, "Door");
        }

        public void AddItem(IInventoryItem item)
        {
            if (item is Door)
            {
                DoorCollection.Add(item as Door);
            }
        }

        public IIterator GetIterator()
        {
            return new Iterator<Door>(DoorCollection);
        }

        public void RemoveItem(IInventoryItem item)
        {
            if (item is Door)
            {
                DoorCollection.Remove(item as Door);
            }
        }
    }
}
