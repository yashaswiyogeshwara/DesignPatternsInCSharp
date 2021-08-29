using IteratorPattern.Interfaces;
using IteratorPattern.Inventory;
using IteratorPattern.Models;
using IteratorPattern.Seedding;
using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GlueInventory glueInventory = new GlueInventory(new Seeder<Glue>());
            DoorInventory doorInventory = new DoorInventory(new Seeder<Door>());
            NutInventory nutInventory = new NutInventory(new Seeder<Nut>());
            Print(glueInventory.GetIterator());
            Print(doorInventory.GetIterator());
            Print(nutInventory.GetIterator());

        }

        static void Print(IIterator iterator) {
            while (!iterator.IsDone()) {
                IInventoryItem item = iterator.Current();
                Console.WriteLine(String.Format("Item Id :{0}, Item Label: {1}", item.Id, item.Label));
                iterator.Next();
            }
        }
    }
}
