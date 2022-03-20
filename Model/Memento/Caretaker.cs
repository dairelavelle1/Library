using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using book;

namespace memento {
    public class Caretaker {
        private List<IMemento> _mementos = new List<IMemento>();
        private Catalog _originator;

        public Caretaker(Catalog catalog) {
            _originator = catalog;
        }

        public void Backup() {
            this._mementos.Add(this._originator.SaveState());
        }

        public void Restore() {
            var memento = this._mementos.Last();
            this._mementos.Remove(memento);
            this._originator.RestoreState(memento);
        }

        public string ShowHistory() {
            string output = "";
            foreach (var memento in this._mementos) {
                output += "Catalog at: "+memento.GetName()+" "+memento.GetState().Count+"\n";
            }
            return output;
        }
    }
}
