﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Interfaces
{
    public interface IIterable
    {
        public IIterator GetIterator();
    }
}
