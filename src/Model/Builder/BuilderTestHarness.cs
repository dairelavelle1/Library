using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using book;

namespace Builder {
    public class BuilderTestHarness {
        public static void Main(string[] args) {
            Director myDirector = new Director();
            NovelBookBuilder novelBookBuilder = new NovelBookBuilder();
            TextbookBookBuilder textbookBookBuilder = new TextbookBookBuilder();
            MagazineBookBuilder magazineBookBuilder = new MagazineBookBuilder();
            string[] harrypotter = {
                "Novel",
                "Harry Potter",
                "9780747532743", 
                "Bloomsbury",
                "Fantasy",
                "novel in the Harry Potter series and features Harry Potter",
                "J. K. Rowling",
                "2000FEB" };
            string[] physics = {
                "Textbook",
                "Basic Physics",
                "9780747532744",
                "Penguin",
                "Physics",
                "Basic physics concepts for 1st year undergraduates",
                "John Man", "Jan Woman", "endAuthors",
                "2",
                "2014DEC20",
                "2015DEC20" };
            string[] carMagazine = {
                "Magazine",
                "Cars Monthly",
                "15802620",
                "Toyota",
                "Vehicles",
                "It's all about cars",
                "346",
                "2022JAN" };
            myDirector.generateBook(novelBookBuilder, harrypotter);
            myDirector.generateBook(textbookBookBuilder, physics);
            myDirector.generateBook(magazineBookBuilder, carMagazine);
            
            Debug.WriteLine(novelBookBuilder.Book);
            Debug.WriteLine(textbookBookBuilder.Book);
            Debug.WriteLine(magazineBookBuilder.Book);
        }
    }
}
