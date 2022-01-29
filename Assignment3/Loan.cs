using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Exception Handling :

 2. Write a class called LoanProcess with Loan_No, Customer Name, LoanAmount, EMI_Amount,Account_Balance as its members. Create a
method calculate_EMI() for the LoanAmount , with the rate of interest as 13% for a total of 3 years and store it in the EMI_Amount.
The rest of the information to be passed through constructors. Write another function CheckBalance() which checks if the Account_Balance
is less than the EMI_AMount. If yes then throw a custom exception. Display " Not Sufficient Balance to repay Loan" in the finally. Give explanatory comments.

Output :
The Name of Customer is : Nikitha
The Customer loan number is : 20984872156
Enter the Loan amount you want to take:
30000
Enter the Account Balance :
1000
Sorry, No Sufficient balance in you account to repay the loan

 */

namespace Assignment
{
    //Exception handling
    class LoanException : ApplicationException
    {
        public LoanException(string message) : base(message)
        {
            
        }
    }
    class LoanDetails
    {
        public long Loan_No;
        public string Customer_Name;
        public double LoanAmount;
        public double EMI_Amount;
        public double Account_Balance;

        public void calculate_EMI()
        {
            // Emi = P*T*R {P=principle amount, T=time(may be in years/months/days), R=rate of interest}
            EMI_Amount = 3 * LoanAmount * 0.13; // interest = 13% = 0.13, years = 3
        }

        //Constructor for taking inputs 
        public LoanDetails(long loanno, string Cust_name, double Loanamt)
        {
            Loan_No = loanno;
            Customer_Name = Cust_name;
            LoanAmount = Loanamt;

        }
        public void CheckBalance()
        {
            
            if(Account_Balance < EMI_Amount)
            {
                // exception is thrown to LoanException class if there is insufficient balance for repaying loan
                throw (new LoanException("Sorry, No Sufficient balance in you account to repay the loan"));
            } else
            {
                Console.WriteLine("Sufficient Balance to debit the amount from your account");
            }
        }
    }
    class Loan
    {
        public static void Main(string[] args)
        {
            //Calling and giving the inputs from Constructor called LoanDetails
            LoanDetails l = new LoanDetails(20984872156, "Nikitha", 40000.38);

            Console.WriteLine("The Name of the Customer is : " + l.Customer_Name);
            Console.WriteLine("The Customer loan number is : " + l.Loan_No);
            Console.WriteLine($"The Loan amount is {l.LoanAmount}");

            //Calling calculate_EMI() method through object l to find out emi
            l.calculate_EMI();

            Console.WriteLine("Enter the Account Balance : ");
            l.Account_Balance = Convert.ToDouble(Console.ReadLine());
            try
            {
                
                //Now calling checkBalance() method to find the whether customer has sufficient balance to repay the loan
                l.CheckBalance();
            }
            catch (LoanException le)
            {
                Console.WriteLine(le.Message);
            }
            Console.ReadLine();
        }
    }
}

