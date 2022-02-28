using System;

public class Director
{
    //generateBook is called with the builder for the type of book you want
    //to create
	public void generateBook(IBookBuilder bookBuilder, string[] bookInfo)
    {
        bookBuilder.buildBook(bookInfo);
    }

    public void addToDatabase(IBookBuilder bookBuilder)
    {

    }
}
