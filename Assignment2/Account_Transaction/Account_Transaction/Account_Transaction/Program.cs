using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1. Create a class called Accounts which has data members like Account no, Customer name,
Account type, Transaction type (d/w), amount, balance
D->Deposit
W->Withdrawal

-write a function that updates the balance depending upon the transaction type

	-If transaction type is deposit call the credit(int amount) function and update balance
	-If transaction type is withdraw call debit(int amt)function and update balance
-Pass the other information like Acount no,name,acc type through constructor
-call the show data method to display the values.
*/

namespace Account_Transaction
{
    class Accounts
    {
        long Acc_no;
        string Cust_name;
        float balance = 60000;
        string Acc_Type;


        public Accounts(long acc_no, string name, string acc_type)
        {
            Acc_no = acc_no;
            Cust_name = name;
            Acc_Type = acc_type;
        }

        public void Transaction_Type()
        {
            Console.WriteLine("Enter the transaction type :D or d");
            var trans_type = Convert.ToChar(Console.ReadLine());
            if (trans_type == 'D' || trans_type == 'd')
            {
                Credit(35000);
            }
            else Debit(20000);
        }

        public void Credit(int amount)
        {
            balance += amount;
            Console.WriteLine($"Available Balance after the Deposit is : {balance} for Customer {Cust_name}");
            Console.WriteLine($"Available Balance is : {balance}");
        }

        public void Debit(int amt)
        {
            balance -= amt;
            Console.WriteLine($"Available Balance after the Withdrawal is : {balance}, {Cust_name}");
            Console.WriteLine($"Available Balance is : {balance}");
        }
        public void Show()
        {
            Console.WriteLine($"Enter Account no : {Acc_no}");
            //Acc_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter Customer name : {Cust_name}");
            //Cust_name = Console.ReadLine();
            Console.WriteLine($"Enter Account type : {Acc_Type}");
            //Acc_Type = Console.ReadLine();
            Console.WriteLine($"Available balance is : {balance}");
            Transaction_Type();
        }


        static void Main()
        {
            //Console.WriteLine("Enter the Customer details : ");

            Accounts acc = new Accounts(456789021, "Nikitha", "Salary Account");
            acc.Show();
            /*
            double amount;
            double Withdrawal;
            while (true)
            {
                Console.WriteLine("Welcome to Transaction Type : \n");
                Console.WriteLine("1. Deposit\n");
                Console.WriteLine("2. Withdrwal\n");
                Console.WriteLine("3. Quit\n");
                Console.WriteLine("Enter your choice : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter the amount to deposit : ");
                        amount = int.Parse(Console.ReadLine());
                        acc.Credit(Convert.ToInt32(amount));
                        Console.WriteLine("The Balance after the deposit is : {0} ",acc.Credit(amount));
                        break;
                    case 2:
                        Console.WriteLine("\nEnter the amount to withdraw: ");
                        Withdrawal = int.Parse(Console.ReadLine());
                        acc.Debit(Convert.ToInt32(Withdrawal));
                        break;
                    case 3:
                        Console.WriteLine("\nThank you");
                        break;
                }
                //Console.WriteLine("Enter the Customer details : ");
                //acc.Account(456789021, "Nikitha", "Salary Account");
            }
            */
        }
    }
}
