using book;
using System;
using System.Collections.Generic;

namespace Builder {
    public abstract class IBookBuilder {
        protected abstract void AddCategory();
        protected abstract void AddTitle(string title);
        protected abstract void AddISBN(string isbn);
        protected abstract void AddISSN(string issn);
        protected abstract void AddPublisher(string publisher);
        protected abstract void AddGenre(string genre);
        protected abstract void AddDescription(string description);
        protected abstract void AddAuthor(string author);
        protected abstract void AddSeries(string series);
        protected abstract void AddEdition(string edition);
        protected abstract void AddVolume(string volume);
        protected abstract void AddIssue(string issue);
        protected abstract void AddPublished(DateTime published);
        //public abstract Book buildBook(string[] arr);
        public abstract Book buildBook(string arr);
    }
}