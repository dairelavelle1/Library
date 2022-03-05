using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder;

namespace Library{
    class Input {

        static void Main(string[] args) { //Entry Point
            StartScreen();
        }

        static void StartScreen() { 
            Console.WriteLine("Hello! Welcome to CS4227 Library!. For list of cmds, type 'help'");
            string input = Console.ReadLine();
            DefaultInputManager(input);
        }


        static void DefaultInputManager(string x) { //Normal user input (ie book checkouts) managed here
            switch (x) {
                case "help":
                    Console.WriteLine("possible cmds: admin, help");
                    StartScreen();
                    break;

                case "admin":
                    Admin();
                    break;

                default:
                    Console.WriteLine("input not recognized");
                    StartScreen();
                    break;
            }
        }

        static void Admin() 
        {
            Console.WriteLine("Welcome to Admin tools. to add new book to the system, type 'book'. To exit Admin tools, type 'exit'");
            string input = Console.ReadLine();
            AdminInputManager(input);

        }

        static void AdminInputManager(string x) { //Admin tasks (ie Scanning new books on to system ) is managed here
            switch (x) {
                case "book":
                    AddBook();
                    break;

                case "exit":
                    StartScreen();
                    break;

                default:
                    Console.WriteLine("input not recognized");
                    Admin();
                    break;
            }
        }

        static void AddBook()
        {
            Director myDirector = new Director();
            Console.WriteLine("Specify Book category :Magazine (m), Novel(n), Textbook(t)");
            string category = Console.ReadLine();
            switch (category)
            {
                case "m":
                    MagazineBookBuilder magazineBookBuilder = new MagazineBookBuilder();
                    string x = BuildMagazine();
                    myDirector.generateBook(magazineBookBuilder, x);
                    break;

                case "n":
                    NovelBookBuilder novelBookBuilder = new NovelBookBuilder();
                    string y = BuildNovel();
                    myDirector.generateBook(novelBookBuilder, y);
                    break;

                case "t":
                    TextbookBookBuilder textbookBookBuilder = new TextbookBookBuilder();
                    string z = BuildTextbook();
                    myDirector.generateBook(textbookBookBuilder, z);
                    break;

                default:
                    Console.WriteLine("input not recognized");
                    AddBook();
                    break;
            }
        }

        static string BuildMagazine()
        {
            string title, issueNum, publisher, genre, description, issue, date, x , returnMe;
            Console.WriteLine("Enter the Title of the Magazine");
            x = Console.ReadLine();
            title = "TITLE:" + x + ";";
            Console.WriteLine("Enter the IssueNumber of the Magazine");
            x = Console.ReadLine();
            issueNum = "ISSN:" + x + ";";
            Console.WriteLine("Enter the Publisher of the Magazine");
            x = Console.ReadLine();
            publisher = "PUBLISHER:" + x + ";";
            Console.WriteLine("Enter the Genre of the Magazine");
            x = Console.ReadLine();
            genre = "GENRE:" + x + ";";
            Console.WriteLine("Enter the description of the Magazine");
            x = Console.ReadLine();
            description = "DESCRIPTION:" + x +";";
            Console.WriteLine("Enter the Issue of the Magazine");
            x = Console.ReadLine();
            issue = "ISSUE:" + x + ";";
            Console.WriteLine("Enter the Date of the Magazine");
            x = Console.ReadLine();
            date = "DATE" + x + ";";
            returnMe = title + issueNum + publisher + genre + description + issue + date;

            Console.WriteLine("is the following information correct? " + returnMe);
            return returnMe;
        }

        static string BuildNovel()
        {
            return "placeholder";
        }

        static string BuildTextbook()
        {
            return "placeholder";
        }
    }
}
