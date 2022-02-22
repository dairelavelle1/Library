using System;

abrstract class Book
{
	private string _title;
    private string _category;
    private string _description;
    private DateTime _published;

    string Title { get => _title; set => _title = value; }
    string Category { get => _category; set => _category = value; }
    string Description { get => _description; set => _description = value; }
    string Published { get => _published; set => _published = value; }
}
