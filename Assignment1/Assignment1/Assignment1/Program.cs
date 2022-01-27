using System;

// (Q1) Write a program in C# to accept the name of the user and greet the user as:
//	“Hi! username
//   Welcome to the world of C#”

namespace Assignment1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            string username;
            Console.WriteLine("Enter the name of the user: \n");
            username = Console.ReadLine();

            Console.WriteLine($"\nHi! {username}");
            // Console.WriteLine("\nHi! {0}", username); -> Can also be written
            // Console.WriteLine("\nHi! " + username); -> Can also be written

            Console.WriteLine("Welcome to the world of C#");
            Console.ReadLine();
        }
    }
}


