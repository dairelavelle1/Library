using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using System.Text.RegularExpressions;
using book;
using memento;

namespace Builder {

	public class TextbookBookBuilder : IBookBuilder, IOriginator {
		private Textbook _book = new Textbook();
		public override Book Book { get { return _book; } }

		protected override void AddCategory() { _book.Category = "Textbook"; }
		protected override void AddTitle(string title) { _book.Title = title; }
		protected override void AddISBN(string isbn) { _book.ISBN = isbn; }
		protected override void AddPublisher(string publisher) { _book.Publisher = publisher; }
		protected override void AddGenre(string genre) { _book.Genre = genre; }
		protected override void AddDescription(string description) { _book.Description = description; }
		protected override void AddAuthor(string author) { _book.AddAuthor(author); }
		protected override void AddEdition(string edition) { _book.Edition = Int32.Parse(edition); }
		protected override void AddPublished(DateTime published) { _book.Published.Add(published); }
		public override void Reset() { _book = new Textbook(); }

		//This method is for textbooks being added by a user
		//The string format is:
		//"AUTHOR:author name;TITLE:book title;ISBN:book's ISBN"
		//it is unordered. Adding additional dates of publication or authors will add to a list
		//Adding additional to any other field will overwrite with the latest  

		public override Book BuildBook(string arr) {
			AddCategory();
            string[] fields = arr.Split(';');
			foreach (string field in fields) {
				if (!(field == "")) {
					string fieldIdentifier = field.Split(':')[0];
					string fieldValue = field.Split(':')[1];
					switch (fieldIdentifier) {
						case "AUTHOR": AddAuthor(fieldValue); break;
						case "TITLE": AddTitle(fieldValue); break;
						case "ISBN": AddISBN(fieldValue); break;
						case "PUBLISHER": AddPublisher(fieldValue); break;
						case "GENRE": AddGenre(fieldValue); break;
						case "DESCRIPTION": AddDescription(fieldValue); break;
						case "EDITION": AddEdition(fieldValue); break;
						case "DATE": AddPublished(DateTime.Parse(fieldValue)); break;
						case "VOLUME": AddVolume(fieldValue); break;
						default: break;
					}
				}
			}
			return this._book;
        }

        protected override void AddISSN(string issn) {
            throw new NotImplementedException();
        }

        protected override void AddSeries(string series) {
            throw new NotImplementedException();
        }

        protected override void AddVolume(string volume) {
            throw new NotImplementedException();
        }

        protected override void AddIssue(string issue) {
            throw new NotImplementedException();
        }
		public IMemento SaveState() {
			return new BookBuilderMemento(Book);
		}

		public void RestoreState(IMemento memento) {
			BookBuilderMemento newItems = (BookBuilderMemento)memento;
			this._book = (Textbook)newItems.GetState();
		}
	}
}