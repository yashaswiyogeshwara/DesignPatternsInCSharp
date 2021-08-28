using IteratorPattern.Interfaces;
using IteratorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Inventory
{
    public class DoorInventory : IInventory
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

        public void RemoveItem(IInventoryItem item)
        {
            if (item is Door)
            {
                DoorCollection.Remove(item as Door);
            }
        }
    }
}
