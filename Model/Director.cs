﻿using System;
using Builder;

public class Director {
    //generateBook is called with the builder for the type of book you want
    //to create
    public void generateBook(IBookBuilder bookBuilder, string bookInfo) {
        bookBuilder.BuildBook(bookInfo);
    }

    public void addToDatabase(IBookBuilder bookBuilder) {

    }

}