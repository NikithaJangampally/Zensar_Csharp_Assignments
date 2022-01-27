using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// (Q3) Write a program in C# to accept two words from user and find out if they are same.

namespace Strings
{
    internal class Matching_Words
    {
        static void Main() {
            string str1;
            string str2;
            Console.WriteLine("Enter First String: ");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter Second String: ");
            str2 = Console.ReadLine();
            if(str1 == str2) {
                Console.WriteLine($"The Given two strings {str1} and {str2} are Same");
            } else
            {
                Console.WriteLine($"The Given two Strings {str1} and {str2} are different");
            }
            Console.ReadLine();
        }
    }


}
