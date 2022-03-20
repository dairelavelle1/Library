using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using memento;

namespace book {
    public class Catalog {
        List<Book> _items;

        public List<Book> Items { get => _items; set => _items = value; }

        public Catalog() {
            Items = new List<Book>();
        }

        public void Add(Book book) {
            Items.Add(book);
        }
        public void Remove(string identifier) {
            foreach (Book book in Items) {
                if (identifier == book.GetID()) {
                    Items.Remove(book);
                }
            }
        }
        public void Remove(Book removeBook) {
            foreach (Book book in Items) {
                if (removeBook == book) {
                    Items.Remove(removeBook);
                }
            }
        }
        public Book Get(string identifier) {
            foreach (Book book in Items) {
                if (book.GetID() == identifier) {
                    return book;
                }
            }
            return Items[0];
        }

        public List<string> Write() {
            List<string> output = new List<string>();
            foreach (Book book in Items) {
                output.Add(book.Writeable());
            }
            return output;
        }

        public IMemento SaveState() {
            return new Memento(Items);
        }

        public void RestoreState(IMemento memento) {
            Items = memento.GetState();
        }
    }
}
