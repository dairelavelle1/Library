using System;
using System.Text.Json;
using book;

namespace Builder {
	public class MagazineBookBuilder : IBookBuilder {
		private Book _book = new Book();
		public Book Book { get { return _book; } }

		protected override void addCategory() { _book.Category = "Magazine"; }
		protected override void addTitle(string title) { _book.Title = title; }
		protected override void addISSN(string issn) { _book.ISBN = issn; }
		protected override void addPublisher(string publisher) { _book.Publisher = publisher; }
		protected override void addGenre(string genre) { _book.Genre = genre; }
		protected override void addDescription(string description) { _book.Description = description; }
		protected override void addIssue(string issue) { _book.IssueNumber = Int32.Parse(issue); }
        protected override void addPublished(string published) { _book.Published = DateTime.Parse(published); }

		//This method is for standard magazines being added by a user
		//The string array format is required to be:
		//{category, title, ISSN, publisher, genre, description, issue number, issue date}
		public override Book buildBook(string[] arr) {
			addCategory();
			int count = 1;
			addTitle(arr[count++]);
			addISSN(arr[count++]);
			addPublisher(arr[count++]);
			addGenre(arr[count++]);
			addDescription(arr[count++]);
			addIssue(arr[count++]);
			addPublished(arr[count]);

			return this._book;
		}

        protected override void addISBN(string isbn) {
            throw new NotImplementedException();
        }

        protected override void addAuthors(string[] authors) {
            throw new NotImplementedException();
        }

        protected override void addSeries(string series) {
            throw new NotImplementedException();
        }

        protected override void addEdition(string edition) {
            throw new NotImplementedException();
        }

        protected override void addVolume(string volume) {
            throw new NotImplementedException();
        }

        protected override void addEditionPublished(string editionPublished) {
            throw new NotImplementedException();
        }
    }
}