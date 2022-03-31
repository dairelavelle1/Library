using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento {
    public interface IOriginator {
        public abstract IMemento SaveState();
        public abstract void RestoreState(IMemento memento);
    }
}
