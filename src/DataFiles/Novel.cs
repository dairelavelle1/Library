using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book {
    internal class Novel : Book{

        private string _ISBN;
        private List<string> _authors;
        private int? _edition;
        private int? _volume;
        private string _series;

        public string ISBN { get => _ISBN; set => _ISBN = value; }
        public List<string> Authors { get => _authors; set => _authors = new List<string>(value); }
        public void AddAuthor(string author) { _authors.Add(author); }
        public int? Edition { get => _edition; set => _edition = value; }
        public int? Volume { get => _volume; set => _volume = value; }
        public string Series { get => _series; set => _series = value; }

        public Novel() { _authors = new List<string>(); }
    }
}