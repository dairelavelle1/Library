using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using book;

namespace memento {
    internal class BookBuilderMemento : IMemento {
        readonly Book _state;
        readonly DateTime _date;

        public BookBuilderMemento(Book state) {
            this._state = state;
            this._date = DateTime.Now;
        }

        public Book GetState() {
            return _state;
        }

        public DateTime GetDate() {
            return _date;
        }

        public override string ToString() {
            return _date.ToString();
        }
    }
}
