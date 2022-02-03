using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
3. Create a simple Stationery application to add items and display added items using Generic collections.

Output:
Enter the number of Stationery Elements you want to add: 4
Enter the Stationery Items:
Craft paper
Exam board
Scissors
Eraser

The Inserted elements of list are :
Craft paper
Exam board
Scissors
Eraser
*/
namespace Assignment4
{
    internal class Stationery
    {
        static void Main()
        {
            int n;
            List<string> str = new List<string>(); //Uaing Generics
            Console.Write("Enter the number of Stationery Elements you want to add: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Stationery Items: ");
            for (int i = 0; i < n; i++)
            {
                str.Add(Console.ReadLine());
            }
            Console.WriteLine("\nThe Inserted elements of list are : ");
            foreach (string s in str)
            {
                
                Console.WriteLine(s);
            }
        }
    }
}
