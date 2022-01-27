using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Largest and smallest of three numbers :\n");

            Console.WriteLine("Enter num1:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter num3:");
            num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("\nLargest number is: {0}", num1);
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("\nLargest number is: {0}", num2);
            }
            else
            {
                Console.WriteLine("\nLargest number is: {0}", num3);
            }


            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("Smallest number is: {0}", num1);
            }
            else if (num2 < num3 && num2 < num1)
            {
                Console.WriteLine($"Smallest number is: {num2}");
            }
            else
            {
                Console.WriteLine("Smallest number is:" + num3);
            }
            Console.Read();
        }
    }
}
