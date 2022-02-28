using System;

namespace Library.src.Book
{
    class Book
    {
        private final string _category;
        private final string _title;
        private final string? _ISBN;
        private final string? _ISSN;
        private final string _publisher;
        private final string _genre;
        private final string _description;
        //Some novels and many textbooks have multiple authors
        private final string[] _authors;
        private final string? _series;
        //Textbooks and novels have editions and volumes, magazines have issues. I'm magazines
        private final int? _edition;
        private final int? _volume;
        private final int? _issue;
        private final DateTime _published;
        private final DateTime? _editionPublished;

        string Title { get => _title; set => _title = value; }
        string ISBN { get => _ISBN; set => _ISBN = value; }
        string ISSN { get => _ISSN; set => _ISSN = value; }
        string Publisher { get => _publisher; set => _publisher = value; }
        string Genre { get => _genre; set => _genre = value; }
        string Category { get => _category; set => _category = value; }
        string Description { get => _description; set => _description = value; }
        string[] Authors { get => _authors; set => _authors = Array.Copy(value, _authors, value.Length); }
        string Series { get => _series; set => _series = value; }
        int Edition { get => _edition; set => _edition = value; }
        int Volume { get => _volume; set => _volume = value; }
        int IssueNumber { get => _issue; set => _issue = value; }
        DateTime Published { get => _published; set => _published = value; }
        DateTime EditionPublished { get => _editionPublished; set => _editionPublished = value; }

        public override string ToString() {
            switch (_category) {
                case = "Novel":
                        return String.Format("{0}\n{1}\n{2}", _title, _authors[0], _genre);
                case = "Textbook":
                        return String.Format("{0}\n{1}\n{2} edition", _title, _authors[0], _edition);
                case = "Magazine":
                        return String.Format("{0} issue {1}", _title, _issue);
            }
        }
    }
}
