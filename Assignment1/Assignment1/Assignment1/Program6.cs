using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//(Q6). Write a Program to assign integer to an array  and then print the following
//a.	Average value of Array elements
//b.	Minimum and Maximum value in an array 

namespace Assignment1
{
    internal class Program6
    {
        static void Main(string[] args)
        {
            int []arr= {34,44,92,67};
            float avg=0;
            int sum = 0;

            //float Maximum = arr[int.MaxValue];
            Console.WriteLine($"The Maximum value is: {arr.Max()}\n");

            //float Minimum = Convert.ToInt32(arr[int.MaxValue]);
            Console.WriteLine($"The Minimum value is: {arr.Min()}\n");

            for (int i = 0; i < arr.Length; i++)
            {
                
                sum = sum + arr[i];
                avg = sum / arr.Length;
            }
            Console.WriteLine($"The Average value of array elements is : {avg}\n");
            Console.ReadLine();
        }
    }
}
