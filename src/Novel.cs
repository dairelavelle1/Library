using System;

class Novel : Book
{
	private string _ISBN;
	private string _author;
	private string _series;
	private int _volume;

	string ISBN { get => _ISBN; set => _ISBN = value; }
	string Author { get => _author; set => _author = value; }
	string Series { get => _series; set => _series = value; }
	int Volume { get => _volume; set => _volume = value; }

	Novel()
}