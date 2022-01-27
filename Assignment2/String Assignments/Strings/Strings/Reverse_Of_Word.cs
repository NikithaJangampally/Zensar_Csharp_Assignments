using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// (Q2) Write a program in C# to accept a word from the user and display the reverse of it.

namespace Strings
{
    internal class Reverse_Of_Word
    {
        static void Main(string[] args)
        {
            string word, Rev_word = " ";
            int i, len;
            Console.WriteLine("Enter any Word : ");
            word = Console.ReadLine();
            len = word.Length - 1;
            for(i = len;i >= 0;i--)
            {
                Rev_word = Rev_word + word[i];
            }
            Console.WriteLine($"Reverse of a word {word} is : {Rev_word}");
            Console.Read();
        }
    }
}
