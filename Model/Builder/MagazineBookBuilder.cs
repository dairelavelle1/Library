using System;
using System.Collections.Generic;
using System.Text.Json;
using book;

namespace Builder {
	public class MagazineBookBuilder : IBookBuilder {
		private Magazine _book = new Magazine();
		public override Book Book { get { return _book; } }
 
		protected override void AddCategory() { _book.Category = "Magazine"; }
		protected override void AddTitle(string title) { _book.Title = title; }
		protected override void AddISSN(string issn) { _book.ISSN = issn; }
		protected override void AddPublisher(string publisher) { _book.Publisher = publisher; }
		protected override void AddGenre(string genre) { _book.Genre = genre; }
		protected override void AddDescription(string description) { _book.Description = description; }
		protected override void AddIssue(string issue) { _book.IssueNumber = Int32.Parse(issue); }
		protected override void AddPublished(DateTime published) { _book.Published.Add(published); }
		public override void Reset() { _book = new Magazine(); }

		//This method is for textbooks being added by a user
		//The string format is:
		//"ISSUE:issue number;TITLE:book title;ISBN:magazine's ISSN"
		//it is unordered. Adding additional dates of publication will add to a list
		//Adding additional to any other field will overwrite with the latest


		//public override Book buildBook(string[] arr) {
		//	AddCategory();
		//	List<DateTime> list = new List<DateTime>();
		//	int count = 1;
		//	AddTitle(arr[count++]);
		//	AddISSN(arr[count++]);
		//	AddPublisher(arr[count++]);
		//	AddGenre(arr[count++]);
		//	AddDescription(arr[count++]);
		//	AddIssue(arr[count++]);
		//	AddPublished(DateTime.Parse(arr[count++]));

		//	return this._book;
		//}
		public override Book BuildBook(string arr) {
			AddCategory();
			string[] fields = arr.Split(';');
			foreach (string field in fields) {
				if (!(field == "")) {
					string fieldIdentifier = field.Split(':')[0];
					string fieldValue = field.Split(':')[1];
					switch (fieldIdentifier) {
						case "TITLE": AddTitle(fieldValue); break;
						case "ISSN": AddISSN(fieldValue); break;
						case "PUBLISHER": AddPublisher(fieldValue); break;
						case "GENRE": AddGenre(fieldValue); break;
						case "DESCRIPTION": AddDescription(fieldValue); break;
						case "ISSUE": AddDescription(fieldValue); break;
						case "DATE": AddPublished(DateTime.Parse(fieldValue)); break;
					}
				}
			}
			return this._book;
		}

		protected override void AddISBN(string isbn) {
            throw new NotImplementedException();
        }

        protected override void AddAuthor(string author) {
            throw new NotImplementedException();
        }

        protected override void AddSeries(string series) {
            throw new NotImplementedException();
        }

        protected override void AddEdition(string edition) {
            throw new NotImplementedException();
        }

        protected override void AddVolume(string volume) {
            throw new NotImplementedException();
        }
    }
}