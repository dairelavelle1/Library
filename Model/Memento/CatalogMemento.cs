using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using book;

namespace memento {
    public class CatalogMemento : IMemento{
        readonly List<Book> _state;
        readonly DateTime _date;

        public CatalogMemento(List<Book> state) {
            this._state = new List<Book>(state);
            this._date = DateTime.Now;
        }

        public List<Book> GetState() {
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