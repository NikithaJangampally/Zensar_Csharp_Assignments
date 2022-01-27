using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// (Q1) Write a program in C# to accept a word from the user and display the length of it.

namespace Strings
{
    internal class Length_Of_Word
    {
        static void Main(string[] args) {
            string word;
            Console.WriteLine("Enter any word : ");
            word = Console.ReadLine();
            int len = word.Length;
            Console.WriteLine($"The length of the word {word} is : {len}");
            Console.Read();
        }
    }
}
