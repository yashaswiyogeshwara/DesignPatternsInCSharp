using IteratorPattern.Interfaces;
using IteratorPattern.Iterators;
using IteratorPattern.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Inventory
{
    public class NutInventory : IInventory, IIterable
    {
        private List<Nut> NutCollection = new List<Nut>();
        public NutInventory(ISeeder<Nut> seeder) 
        {
            seeder.SeedData(this, "Nut");
        }

        public void AddItem(IInventoryItem item)
        {
            if (item is Nut) {
                NutCollection.Add(item as Nut);
            }
        }
        
        public IIterator GetIterator()
        {
            return new Iterator<Nut>(NutCollection);
        }

        public void RemoveItem(IInventoryItem item)
        {
            if (item is Nut)
            {
                NutCollection.Remove(item as Nut);
            }
        }
    }
}
