using System;

class Textbook : Book
{
	private string _ISBN;
	private string[] _authors;
	private string _edition;

	string ISBN { get => _ISBN; set => _ISBN = value; }
	string[] Authors { get => _authors; set => _authors = value; }
	string Edition { get => _edition; set => _edition = value; }

	Textbook()
}