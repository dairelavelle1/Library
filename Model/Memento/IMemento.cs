using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using book;

namespace memento {
    public abstract class IMemento {
        /*
         * children of this class are expected to:
         * store state
         * return state
         * override String.ToString()
         */
    }
}
