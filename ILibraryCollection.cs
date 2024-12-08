using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_pattern
{
    public interface ILibraryCollection
    {
        IIterator CreateIterator();
    }
}
