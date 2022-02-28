using System;
using Library.src.Book;

public abstract class IBookBuilder
{
	abstract void addCategory();
	abstract void addTitle();
	abstract void addISBN();
	abstract void addISSN();
	abstract void addPublisher();
	abstract void addGenre();
	abstract void addDescription();
	abstract void addAuthors();
	abstract void addSeries();
	abstract void addEdition();
	abstract void addVolume();
	abstract void addIssue();
	abstract void addPublished();
	abstract void addEditionPublished();
	abstract Book buildBook();
}
