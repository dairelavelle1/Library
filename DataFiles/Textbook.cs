using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book {
    internal class Textbook : Book {

        private string _ISBN;
        private List<string> _authors;
        private int _edition;
        private int? _volume;

        public string ISBN { get => _ISBN; set => _ISBN = value; }
        public List<string> Authors { get => _authors; set => _authors = new List<string>(value); }
        public void AddAuthor(string author) { _authors.Add(author); }
        public int Edition { get => _edition; set => _edition = value; }
        public int? Volume { get => _volume; set => _volume = value; }
        public override string GetID() {
            string output = _ISBN;
            if (!(_volume == null)) { output += "_" + _volume; }
            output += "_" + _edition;
            return (output);
        }

        public Textbook() { _authors = new List<string>(); Category = "TEXTBOOK"; }

        public override string Writeable() {
            string output = "TEXTBOOK_";
            output += "TITLE:" + Title + ";";
            foreach (var author in Authors) { output += "AUTHOR:" + author + ";"; }
            output += "ISBN:" + ISBN + ";";
            output += "EDITION:" + Edition + ";";
            output += "GENRE:" + Genre + ";";
            output += "PUBLISHER:" + Publisher + ";";
            output += "DESCRIPTION:" + Description + ";";
            foreach (var date in Published) { output += "PUBLISHED:" + date.ToString() + ";"; }
            return output;
        }
    }
}