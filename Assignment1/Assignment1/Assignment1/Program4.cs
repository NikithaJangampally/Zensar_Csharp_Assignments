using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// (Q4).Write a program which accepts marks of 5 students for C#,HTML and Sql (3 subjects),
// calculates the average and prints result as passed or failed If avg< 50 then failed else passed. 


namespace Assignment1
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            double m1, m2, m3;
            float avg;
            double total;
            string name;
            Console.WriteLine("Enter the 5 students marks: \n");
            for(int i=0;i<=5;i++)
            {
                Console.WriteLine("Enter the name of the student: ");
                name = Console.ReadLine();

                Console.WriteLine("\nEnter C# marks: ");
                m1= Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nEnter Html marks: ");
                m2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nEnter Sql marks: ");
                m3= Convert.ToDouble(Console.ReadLine());

                total = m1 + m2 + m3;
                Console.WriteLine($"\nThe Total of C#, Html, Sql subject marks of {name} is: {total}");

                avg = (float)total / 3;
                Console.WriteLine($"\nThe Average of C#, Html, Sql marks of {name} is: {avg}");

                if(avg < 50)
                {
                    Console.WriteLine($"\nThe Status of {name} is Fail");
                } else
                {
                    Console.WriteLine($"\nThe Status of {name} is Pass");
                }
                Console.ReadLine();
            }
            Console.ReadLine();

        }
    }
}
