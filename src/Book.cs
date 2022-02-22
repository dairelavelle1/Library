using System;

class Book
{
	private string _title;
    private string _ISBN;
    private string _ISSN;
    private string _category;
    private string _genre;
    private string _description;
    //Some novels and many textbooks have multiple authors
    private string[] _authors;
    private string _series;
    //Textbooks and novels have editions, magazines have issues. I'm magazines
    private int _edition;
    private int _volume;
    private int _issue;
    private DateTime _published;
    private DateTime _editionPublished;

    string Title { get => _title; set => _title = value; }
    string ISBN { get => _ISBN; set => _ISBN = value; }
    string ISSN { get => _ISSN; set => _ISSN = value; }
    string Genre { get => _genre; set => _genre = value; }
    string Category { get => _category; set => _category = value; }
    string Description { get => _description; set => _description = value; }
    string[] Authors { get => _authors; set => _authors = value; }
    string Series { get => _series; set => _series = value; }
    int Edition { get => _edition; set => _edition = value; }
    int Volume { get => _volume; set => _volume = value; }
    int IssueNumber { get => _issue; set => _issue = value; }
    DateTime Published { get => _published; set => _published = value; }
    DateTime EditionPublished { get => _editionPublished; set => _editionPublished = value; }

    Book()
}
