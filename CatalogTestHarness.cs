using Builder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using book;
using System.Diagnostics;

namespace Library {
    internal class CatalogTestHarness {
        public static void Main(string[] args) {
            Catalog myCatalog = new Catalog();
            Director myDirector = new Director();
            NovelBookBuilder novelBookBuilder = new NovelBookBuilder();
            TextbookBookBuilder textbookBookBuilder = new TextbookBookBuilder();
            MagazineBookBuilder magazineBookBuilder = new MagazineBookBuilder();
            List<IBookBuilder> bookBuilderList = new List<IBookBuilder>() { novelBookBuilder,magazineBookBuilder,textbookBookBuilder};
            var path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\catalog.txt");
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines) {
                foreach (var builder in bookBuilderList) {
                    if (builder.Book.Category == line.Split('_')[0]) {
                        myDirector.generateBook(builder, line.Split('_')[1]);
                        myCatalog.Add(builder.Book);
                        builder.Reset();
                    }
                }
            }
            Debug.Print(myCatalog.Get().Title);
        }
    }
}