using IteratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Seedding
{
    public class Seeder<T> : ISeeder<T> where T: class, IInventoryItem, new()
    {
        public void SeedData(IInventory inventory, string labelSuffix) 
        {
            for (int i = 0; i < 10; i++)
            {
                inventory.AddItem(new T()
                {
                    Id = Guid.NewGuid(),
                    Label = labelSuffix + ((char)(65 + i)).ToString()
                });
            }
        }
    }
}
