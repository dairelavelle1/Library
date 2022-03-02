using System;
using System.Text.Json;
using book;

namespace Builder {

	public class NovelBookBuilder : IBookBuilder {
		private Book _book = new Book();
		public Book Book { get { return _book; } }

		protected override void addCategory() { _book.Category = "Novel"; }
		protected override void addTitle(string title) { _book.Title = title; }
		protected override void addISBN(string isbn) { _book.ISBN = isbn; }
		protected override void addPublisher(string publisher) { _book.Publisher = publisher; }
		protected override void addGenre(string genre) { _book.Genre = genre; }
		protected override void addDescription(string description) { _book.Description = description; }
		protected override void addAuthors(string[] authors) { _book.Authors = authors; }
		protected override void addSeries(string series) { _book.Series = series; }
		protected override void addEdition(string edition) { _book.Edition = Int32.Parse(edition); }
		protected override void addPublished(string published) { _book.Published = DateTime.Parse(published); }
		protected override void addEditionPublished(string editionPublished) { _book.EditionPublished = DateTime.Parse(editionPublished); }

		//This method is for standard novels being added by a user
		//The string array format is required to be:
		//{category, title, ISBN, publisher, genre, description, author, date published}
		//This method is not for books in a series, new editions of old books
		public override Book buildBook(string[] arr) {
			addCategory();
			int count = 1;
			addTitle(arr[count++]);
			addISBN(arr[count++]);
			addPublisher(arr[count++]);
			addGenre(arr[count++]);
			addDescription(arr[count++]);
			addAuthors(new string[] { arr[count++] });
			addPublished(arr[count]);

			return this._book;
		}

        protected override void addISSN(string issn) {
            throw new NotImplementedException();
        }

        protected override void addVolume(string volume) {
            throw new NotImplementedException();
        }

        protected override void addIssue(string issue) {
            throw new NotImplementedException();
        }
    }
}