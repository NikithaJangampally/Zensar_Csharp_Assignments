using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalculateConcession; // adding Class Library

/*
 * 1. Create a class library CalculateConcession ()  that takes age as an input and calculates concession for travel as below:
If age<=5 then “Little Champs- Free Ticket” should be displayed
If age >60 then calculate 30% concession on the totalfare(Which is a constant Eg:500/-) and Display “ Senior Citizen” + Calculated Fare
Else “Print Ticket Booked” + Fare. 
Create a Console application with a Class called Program which has TotalFare as Constant, Name, Age.  Accept Name, Age from the user and call the CalculateConcession() function

Output:-
Enter No. of Tickets You Want to Book: 3
Enter Citizen Name:
Nikitha
Enter Age of Citizen :
62
Senior Citizen has to pay:Rs.485
Enter Citizen Name:
Shivani
Enter Age of Citizen :
50
Ticked Booked with a payment of Rs.500
Enter Citizen Name:
Maanvi
Enter Age of Citizen :
5
Little Champs-Free Ticket
*/

namespace Assignment4
{
    class Program1
    {
        static void Main()
        {
            int TotalFare = 500;
            string Name;
            int Age;
            Console.Write("Enter No. of Tickets You Want to Book: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Citizen Name: ");
                Name = Console.ReadLine();
                Concession c = new Concession();
                c.CalculateConcession1();
            }
        }
    }
}
