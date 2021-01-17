using System;

namespace Assignment1ForWhileDowhile
{
    class Program
    {
        static string choice;
        static string username = "username";
        static string password = "password";

        
        static void Main(string[] args)
        {
            Console.WriteLine("For For loop enter 1: ");
            Console.WriteLine("For While loop enter 2: ");
            Console.WriteLine("For Do While loop enter 3: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You have chosen a For loop method");
                    forMethod(username, password);
                    break;
                case "2":
                    Console.WriteLine("You have chosen a While loop method");
                    whileMethod(username, password);
                    break;
                case "3":
                    Console.WriteLine("You have chosen a Do While loop method");
                    doWhileMethod(username, password);
                    break;
                default:
                    Console.WriteLine("You did not chose any of the methods. The application with terminate");
                    System.Environment.Exit(1);
                    break;
            }

        }
        private static void forMethod(string username, string password)
        {
            string[] credentials = {"", ""};
            int i;

            for (i = 1; i > 0; i++)
            {
                Console.WriteLine("Please enter your username: ");
                credentials[0] = Console.ReadLine();

                Console.WriteLine("Please enter your password: ");
                credentials[1] = Console.ReadLine();

                if (credentials[0] == username && credentials[1] == password)
                {
                    Console.WriteLine("You are now logged in");
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Username or password incorrect. Please try again");
                }
            }

        }

        private static void whileMethod(string username, string password)
        {
            string[] credentials = {"", ""};

            while (true)
            {
                Console.WriteLine("Please enter your username: ");
                credentials[0] = Console.ReadLine();

                Console.WriteLine("Please enter your password: ");
                credentials[1] = Console.ReadLine();

                if (credentials[0] == username && credentials[1] == password)
                {
                    Console.WriteLine("You are now logged in");
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Username or password incorrect. Please try again");
                }
            }

        }

        private static void doWhileMethod(string username, string password)
        {
            string[] credentials = { "", "" };
            do
            {
                Console.WriteLine("Please enter your username: ");
                credentials[0] = Console.ReadLine();

                Console.WriteLine("Please enter your password: ");
                credentials[1] = Console.ReadLine();

                if (credentials[0] == username && credentials[1] == password)
                {
                    Console.WriteLine("You are now logged in");
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Username or password incorrect. Please try again");
                }
            }
            while (true);
            

        }
    }
}
