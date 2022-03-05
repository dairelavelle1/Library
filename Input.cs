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
            Console.WriteLine("Specify Book category :Magazine (M), Novel(N), Textbook(T)");
            string category = Console.ReadLine();
            NovelBookBuilder novelBookBuilder = new NovelBookBuilder();
            myDirector.generateBook(novelBookBuilder, x);
        }
    }
}
