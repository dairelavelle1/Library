using System;

class Magazine : Book
{
	private string _ISSN;
	private int _issue;

	string ISSN { get => _ISSN; set => _ISSN = value; }
	int IssueNumber { get => _issue; set => _issue = value; }

	Magazine()
}