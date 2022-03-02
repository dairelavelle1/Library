using System;
using System.Text.Json;
using book;

namespace Builder {

	public class TextbookBookBuilder : IBookBuilder {
		private Book _book = new Book();
		public Book Book { get { return _book; } }

		protected override void addCategory() { _book.Category = "Textbook"; }
		protected override void addTitle(string title) { _book.Title = title; }
		protected override void addISBN(string isbn) { _book.ISBN = isbn; }
		protected override void addPublisher(string publisher) { _book.Publisher = publisher; }
		protected override void addGenre(string genre) { _book.Genre = genre; }
		protected override void addDescription(string description) { _book.Description = description; }
		protected override void addAuthors(string[] authors) { _book.Authors = authors; }
		protected override void addEdition(string edition) { _book.Edition = Int32.Parse(edition); }
		protected override void addPublished(string published) { _book.Published = DateTime.Parse(published); }
		protected override void addEditionPublished(string editionPublished) { _book.EditionPublished = DateTime.Parse(editionPublished); }

		//This method is for standard textbooks being added by a user
		//The string array format is required to be:
		//{category, title, ISBN, publisher, genre, description, author1, author2, .. , "endAuthors", edition, date published, edition published date}
		public override Book buildBook(string[] arr) {
			string[] arrAuthors;
			int count = 1;
			addCategory();
			addTitle(arr[count++]);
			addISBN(arr[count++]);
			addPublisher(arr[count++]);
			addGenre(arr[count++]);
			addDescription(arr[count++]);
			arrAuthors = new string[Array.IndexOf(arr, "endAuthors") - count];
			Array.Copy(arr, count, arrAuthors, 0, Array.IndexOf(arr,"endAuthors")-count);
			count+=arrAuthors.Length+1;
			addAuthors(arrAuthors);
			addEdition(arr[count++]);
			addPublished(arr[count++]);
			addEditionPublished(arr[count]);

			return this._book;
		}

        protected override void addISSN(string issn) {
            throw new NotImplementedException();
        }

        protected override void addSeries(string series) {
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