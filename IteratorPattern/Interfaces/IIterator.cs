using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Interfaces
{
    public interface IIterator
    {
        public bool IsDone();
        public IInventoryItem Current();
        public void Next();
    }
}
