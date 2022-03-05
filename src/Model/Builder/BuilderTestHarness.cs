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
            string harrypotter = 
                "TITLE:Harry Potter;"+
                "ISBN:9780747532743;"+ 
                "PUBLISHER:Bloomsbury;"+
                "GENRE:Fantasy;"+
                "DESCRIPTION:novel in the Harry Potter series and features Harry Potter;"+
                "AUTHOR:J. K. Rowling;"+
                "DATE:2000FEB";
            string physics = 
                "TITLE:Textbook;"+
                "TITLE:Basic Physics;"+
                "ISBN:9780747532744;"+
                "PUBLISHER:Penguin;"+
                "GENRE:Physics;"+
                "DESCRIPTION:Basic physics concepts for 1st year undergraduates;"+
                "AUTHOR:John Man;AUTHOR:Jan Woman;"+
                "EDITION:2;"+
                "DATE:2014DEC20;"+
                "DATE:2015DEC20";
            string carMagazine = 
                "TITLE:Cars Monthly;"+
                "ISSN:15802620;"+
                "PUBLISHER:Toyota;"+
                "GENRE:Vehicles;"+
                "DESCRIPTION:It's all about cars;"+
                "ISSUE:346;"+
                "DATE:2022JAN";
            myDirector.generateBook(novelBookBuilder, harrypotter);
            myDirector.generateBook(textbookBookBuilder, physics);
            myDirector.generateBook(magazineBookBuilder, carMagazine);
            
            Debug.WriteLine(novelBookBuilder.Book);
            Debug.WriteLine(textbookBookBuilder.Book);
            Debug.WriteLine(magazineBookBuilder.Book);
        }
    }
}