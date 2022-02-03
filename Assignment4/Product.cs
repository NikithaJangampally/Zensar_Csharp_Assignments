using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 2.. Create a Class called Products with Productid, Product Name, Price. Accept 10 Products, sort them based on
 the price, and display the sorted Products

Output:

 */

namespace Assignment4
{
    class Product
    {

        Dictionary<string, Double> Products = new Dictionary<string, double>(); // Dictonary for (Key,value)
        public void InputData()
        {
            Console.WriteLine("Enter 10 Products with their prices: ");
            for (int i = 0; i < 10; i++)
            {
                Products.Add(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));
            }
        }
        public void Sortdata()
        {
            Console.WriteLine("After Sorting the Product by Price :");
            foreach (KeyValuePair<string, Double> Cost in Products.OrderBy(key => key.Value))
            {
                Console.WriteLine($"Product: {Cost.Key}, Value: {Cost.Value}");
            }
        }
    }

    class Products { 
        static void Main(string[] args)
        {
            Product p = new Product();
            p.InputData();
            p.Sortdata();
        }
    }
}

/*
 * Output :
 * mobile
100
tablet
200
Refrigirator
299
ipad
4903
stove
30000
washing machine
15000
laptop
70000
headsets
4000
router
2000
mixer
4000
After Sorting the Product by Price :
Product: mobile, Value: 100
Product: tablet, Value: 200
Product: Refrigirator, Value: 299
Product: router, Value: 2000
Product: headsets, Value: 4000
Product: mixer, Value: 4000
Product: ipad, Value: 4903
Product: washing machine, Value: 15000
Product: stove, Value: 30000
Product: laptop, Value: 70000
*/
