using System;
using book;

namespace Builder {
	public abstract class IBookBuilder {
		protected abstract void addCategory();
		protected abstract void addTitle(string title);
		protected abstract void addISBN(string isbn);
		protected abstract void addISSN(string issn);
		protected abstract void addPublisher(string publisher);
		protected abstract void addGenre(string genre);
		protected abstract void addDescription(string description);
		protected abstract void addAuthors(string[] authors);
		protected abstract void addSeries(string series);
		protected abstract void addEdition(string edition);
		protected abstract void addVolume(string volume);
		protected abstract void addIssue(string issue);
		protected abstract void addPublished(string published);
		protected abstract void addEditionPublished(string editionPublished);
		public abstract Book buildBook(string[] arr);
	}
}