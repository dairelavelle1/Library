using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using book;

namespace memento {
    public class Caretaker {
        private List<IMemento> _mementos = new List<IMemento>();
        private IOriginator _originator;

        public Caretaker(IOriginator caretakee) {
            _originator = caretakee;
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
                output += memento+"\n";
            }
            return output;
        }
    }
}
