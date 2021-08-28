using IteratorPattern.Interfaces;
using IteratorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Inventory
{
    public class GlueInventory : IInventory
    {
        private List<Glue> GlueCollection = new List<Glue>();
        public GlueInventory(ISeeder<Glue> seeder)
        {
            seeder.SeedData(this,"Glue");
        }

        
        public void AddItem(IInventoryItem item)
        {
            if (item is Glue)
            {
                GlueCollection.Add(item as Glue);
            }
        }

        public void RemoveItem(IInventoryItem item)
        {
            if (item is Glue)
            {
                GlueCollection.Remove(item as Glue);
            }
        }
    }
}
