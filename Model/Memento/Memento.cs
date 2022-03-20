using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using book;

namespace memento {
    public class Memento : IMemento{
        readonly List<Book> _state;
        readonly DateTime _date;

        public Memento(List<Book> state) {
            this._state = new List<Book>(state);
            this._date = DateTime.Now;
        }

        public override List<Book> GetState() {
            return _state;
        }

        public override DateTime GetDate() {
            return _date;
        }

        public override string GetName() {
            return _date.ToString();
        }
    }
}
