using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Exception Handling :

 1. Create a console application to book train tickets.Create a Passanger class with (Name, Age) and write a function called
TicketBooking(no_of_tickets) that takes no.of tickets to be booked. If the no of tickets is > 5 per booking,raise an user defined exception,
and print "cannot book more than 2 tickets".Else Print  "Ticket Booked Successfully". Add a Test class to call TicketBooking method by accepting all required details.

Output :
Enter the name of passenger:
Nikitha
Enter the age of passenger:
21
Enter the Number of tickets :
9
Sorry, Cannot book more than 5 tickets

 */

namespace Assignment
{ 
    class TicketException : ApplicationException
    {
        public TicketException(string msge) : base(msge)
        {

        }
    }
    class Passenger
    {
        public string Name;
        public int Age;

        public void Inputdata()
        {
            Console.WriteLine("Enter the name of passenger: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the age of passenger: ");
            Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the number of tickets: ");
            //no_of_tickets = Convert.ToInt32(Console.ReadLine());
        }
        public void TicketBooking(int no_of_tickets)
        {
            if (no_of_tickets > 5)
            {
                throw (new TicketException("Cannot book more than 5 tickets"));
            }
            else
            {
                Console.WriteLine("Ticket booked Successfully");
            }
        }
    }
    class TestProgram
    {
        static void Main(string[] args)
        {
            //int no_tickets;
            Passenger p = new Passenger();
            p.Inputdata();
            Console.WriteLine("Enter the Number of tickets : ");
            int no_tickets = Convert.ToInt32(Console.ReadLine());
            try
            {
                p.TicketBooking(no_tickets);
            }
            catch (TicketException t)
            {
                Console.WriteLine("Sorry, " + t.Message);
            }
            Console.ReadLine();

        }
    }
}
