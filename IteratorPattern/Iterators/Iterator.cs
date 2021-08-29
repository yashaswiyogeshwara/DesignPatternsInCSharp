using IteratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterators
{
    public class Iterator<T> : IIterator where T : class, IInventoryItem, new()
    {
        private List<T> Items;
        private int index;
        public Iterator(List<T> items)
        {
            Items = items;
        }
        public IInventoryItem Current()
        {
            return Items[index];
        }

        public bool IsDone()
        {
            return index >= Items.Count;
            
        }

        public void Next()
        {
            index++; 
        }
    }
}
