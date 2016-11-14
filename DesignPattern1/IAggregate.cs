using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern01_Iterator
{
    interface IAggregate
    {
        IIterator iterator();
    }
}
