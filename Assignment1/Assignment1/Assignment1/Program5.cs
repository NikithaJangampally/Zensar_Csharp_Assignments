using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Temperature fahrenheit to celsius

namespace Assignment1
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            double celsius;
            Console.Write("Enter temperature in fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in celsius is: " + celsius);
            Console.ReadLine();
        }
    }
}
