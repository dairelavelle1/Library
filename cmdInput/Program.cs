using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdInput
{
    class Program
    {

        static void Main(string[] args)
        {
            StartScreen();
        }

        static void StartScreen()
        {
            Console.WriteLine("Hello! Welcome to CS4227 Library!. For list of cmds, type 'help'");
            string input = Console.ReadLine();
            DefaultInputManager(input);
        }

        static void Admin()
        {
            Console.WriteLine("Welcome to Admin tools. to add new book to the system, type 'book'. To exit Admin tools, type 'exit'");
            string input = Console.ReadLine();
            AdminInputManager(input);

        }

        static void DefaultInputManager(string x)
        {
            switch (x)
            {
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

        static void AdminInputManager(string x)
        {
            switch (x)
            {
                case "book":
                    Console.WriteLine("To add book, type PLACEHOLDER");
                    StartScreen();
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
    }
}
