using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using book;

namespace memento {
    public abstract class IMemento {

        public abstract List<Book> GetState();
        public abstract DateTime GetDate();

        public abstract string GetName();
    }
}
