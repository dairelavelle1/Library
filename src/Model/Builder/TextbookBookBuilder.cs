using System;
using System.Text.Json;
using Library.src.Book;

public class TextbookBookBuilder : IBookBuilder
{
	private Book _book = new Book();

	override void addCategory() { _book.Category = "Textbook" }
	override void addTitle(string title) { _book.Title = title; }
	override void addISBN(string isbn) { _book.ISBN = isbn; }
	override void addPublisher(string publisher) { _book.Publisher = publisher; }
	override void addGenre(string genre) { _book.Genre = genre; }
	override void addDescription(string description) { _book.Description = description; }
	override void addAuthors(string[] authors) { _book.Authors = authors; }
	override void addEdition(int edition) { _book.Edition = edition; }
	override void addPublished(DateTime published) { _book.Published = published; }
	override void addEditionPublished(DateTime editionPublished) { _book.EditionPublished = editionPublished; }

	//This method is for standard textbooks being added by a user
	//The string array format is required to be:
	//{category, title, ISBN, publisher, genre, description, author1, author2, .. , "endAuthors", edition, date published, adition published date}
	public override Book buildBook(string[] in) {
		addCategory();
		int count = 1;
		addTitle(in[count++]);
		addISBN(in[count++]);
		addPublisher(in[count++]);
		addGenre(in[count++]);
		addDescription(in[count]);
		while (++count != "endAuthors") {
			addAuthors(in[count]);
		}
		addEdition(count++);
		addPublished(in[count++]);
		addEditionPublished(in[count]);

		return this._book;
	}
}
