using System;
using System.Collections.Generic;

namespace book
{
    public abstract class Book
    {
        private string _category;
        private string _title;
        private string _publisher;
        private string _genre;
        private string _description;
        private List<DateTime> _published;

        public string Title { get => _title; set => _title=value; }
        public string Publisher { get => _publisher ; set => _publisher = value; }
        public string Genre { get => _genre ; set => _genre = value; }
        public string Category { get => _category ; set => _category = value; }
        public string Description { get => _description ; set => _description = value; }
        public List<DateTime> Published { get => _published ; set => _published = new List<DateTime>(value); }
        public void AddPublished(DateTime published) { _published.Add(published); }
        public virtual string GetID() { return _title; }
        public Book() { _published = new List<DateTime>(); }

        public override string ToString() {
            return Title;
        }

        public virtual string Writeable() { return Title; }
    }
}