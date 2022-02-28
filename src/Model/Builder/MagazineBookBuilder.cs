using System;
using System.Text.Json;
using Library.src.Book;

public class MagazineBookBuilder : IBookBuilder
{
	private Book _book = new Book();

	override void addCategory() { _book.Category = "Magazine" }
	override void addTitle(string title) { _book.Title = title; }
	override void addISSN(string issn) { _book.ISBN = issn; }
	override void addPublisher(string publisher) { _book.Publisher = publisher; }
	override void addGenre(string genre) { _book.Genre = genre; }
	override void addDescription(string description) { _book.Description = description; }
	override void addIssue(string issue) { _book.Issue = issue; }
	override void addPublished(DateTime published) { _book.Published = published; }

	//This method is for standard magazines being added by a user
	//The string array format is required to be:
	//{category, title, ISSN, publisher, genre, description, issue number, issue date}
	public override Book buildBook(string[] in)
	{
		addCategory();
		int count = 1;
		addTitle(in[count++]);
		addISSN(in[count++]);
		addPublisher(in[count++]);
		addGenre(in[count++]);
		addDescription(in[count++]);
		addIssue(in[count++]);
		addPublished(in[count]);

		return this._book;
	}
}
