using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number: \n");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number {0} is an Even number", num);
            }
            else
            {
                Console.WriteLine("Number {0} is an Odd number", num);
            }
            Console.ReadLine();
        }
    }
}
