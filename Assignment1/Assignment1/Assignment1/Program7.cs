using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Arrays:
 (Q7).Write a program in C# to accept ten marks and display the following
a.	Total
b.	Average
c.	Minimum marks
d.	Maximum marks
e.	Display marks in ascending order
f.	Display marks in descending order

*/

namespace Assignment1
{
    internal class Program7
    {
        static void Main(string[] args)
        {
         double sum = 0, avg = 0;
            double max = 0, min = 9999999;
            Console.Write("Enter the Array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];

            
            for (int i = 0; i < num.Length; i++)
            {

                num[i] = Convert.ToInt32(Console.ReadLine());
                sum += num[i];

                if (num[i] > max)
                    max = num[i];
                if (num[i] < min)
                    min = num[i];
            }

            
            avg = sum / num.Length;
            Console.WriteLine("The Total is : "+sum);
            Console.WriteLine("The Average is : " + avg);
            Console.Write("The Maximum element : {0}\n", max);
            Console.Write("The Minimum element : {0}", min);


            Array.Sort(num);
            Console.WriteLine("\nMarks in the Ascending Order");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }

            Array.Reverse(num);
            Console.WriteLine("\nMarks in the Descending Order");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }

        }
    }
}
