using System;
using System.Text.Json;
using Library.src.Book;

public class NovelBookBuilder : IBookBuilder
{
	private Book _book = new Book();

	override void addCategory() { _book.Category = "Novel" }
	override void addTitle(string title) { _book.Title = title; }
	override void addISBN(string isbn) { _book.ISBN = isbn; }
	override void addPublisher(string publisher) { _book.Publisher = publisher; }
	override void addGenre(string genre) { _book.Genre = genre; }
	override void addDescription(string description) { _book.Description = description; }
	override void addAuthors(string[] authors) { _book.Authors = authors; }
	override void addSeries(string series) { _book.Series = series; }
	override void addEdition(int edition) { _book.Edition = edition; }
	override void addPublished(DateTime published) { _book.Published = published; }
	override void addEditionPublished(DateTime editionPublished) { _book.EditionPublished = editionPublished; }

	//This method is for standard novels being added by a user
	//The string array format is required to be:
	//{category, title, ISBN, publisher, genre, description, author, date published}
	//This method is not for books in a series, new editions of old books
	public override Book buildBook(string[] in) {
		addCategory();
		int count = 1;
		addTitle(in[count++]);
		addISBN(in[count++]);
		addPublisher(in[count++]);
		addGenre(in[count++]);
		addDescription(in[count++]);
		addAuthors(in[count++]);
		addPublished(in[count]);

		return this._book; 
	}
}