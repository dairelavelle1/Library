using System;

namespace book
{
    public class Book
    {
        private string _category;
        private string _title;
        private string _ISBN;
        private string _ISSN;
        private string _publisher;
        private string _genre;
        private string _description;
        //Some novels and many textbooks have multiple authors
        private string[] _authors;
        private string _series;
        //Textbooks and novels have editions and volumes, magazines have issues. I'm magazines
        private int? _edition;
        private int? _volume;
        private int? _issue;
        private DateTime _published;
        private DateTime _editionPublished;

        public string Title { get; set; }
        public string ISBN { get; set; }
        public string ISSN { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string[] Authors { get => _authors; set { _authors = new string[value.Length]; Array.Copy(value, _authors, value.Length); } }
        public string Series { get; set; }
        public int? Edition { get; set; }
        public int? Volume { get; set; }
        public int? IssueNumber { get; set; }
        public DateTime Published { get; set; }
        public DateTime EditionPublished { get; set; }

        public override string ToString() {
            if (_category.Equals("Novel")) {
                return String.Format("{0}\n{1}\n{2}", _title, _authors[0], _genre);
            } else if (_category.Equals("Textbook")) {
                return String.Format("{0}\n{1}\n{2} edition", _title, _authors[0], _edition);
            } else if (_category.Equals("Magazine")) {
                return String.Format("{0} issue {1}", _title, _issue);
            } else return String.Empty;
        }
    }
}
