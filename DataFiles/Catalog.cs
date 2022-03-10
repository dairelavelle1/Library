using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book {
    public class Catalog {
        List<Book> items;
        public Catalog() {
            items = new List<Book>();
        }

        public void Add(Book book) {
            items.Add(book);
        }
        public void Remove(string identifier) {
            foreach (Book book in items) {
                if (identifier == book.GetID()) {
                    items.Remove(book);
                }
            }
        }
        public Book Get() {
            return items[0];
        }
    }
}
