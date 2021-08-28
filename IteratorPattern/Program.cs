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

        }
    }
}
