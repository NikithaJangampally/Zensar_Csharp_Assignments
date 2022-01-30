using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 5. Write a program in C# Sharp to create a nested structure to store two data for an employee in an array. 

Test Data:

Create a nested structure and store data in an array :                              
-------------------------------------------------------                          
Name of the employee : H.Rana                                                    
Input day of the birth : 05                                                      
Input month of the birth : 02                                                    
Input year for the birth : 58                                                    
                                                                                 
Name of the employee : S.Mathur                                                  
Input day of the birth : 04                                                      
Input month of the birth : 08                                                    
Input year for the birth : 59 

  */

namespace Assignment3
{
    class Nested_Structure
    {
        //employee is a structure of members eName and DOB
        struct employee
        {
            public string eName;
            public DOB Date;
        }
        //DOB is a nested structure of employee
        struct DOB
        {
            public int Date;
            public int Month;
            public int Year;
        }
        static void Main(string[] args)
        {

            int d, m, y;
            string s;

            Console.WriteLine("Create a nested structure and store data in an array :");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Enter Total no of employee you want to enter");
            int t = Convert.ToInt32(Console.ReadLine());
            employee[] e = new employee[t];

            for (int i = 0; i < 2; i++)
            {
                //Initializing the data of name, day, month and year of Date of Birth in structure
                Console.Write("Name of the employee : ");
                s = Console.ReadLine();
                e[i].eName = s;

                Console.Write("Enter day of the birth : ");
                d = Convert.ToInt32(Console.ReadLine());
                e[i].Date.Date = d;

                Console.Write("Enter month of the birth : ");
                m = Convert.ToInt32(Console.ReadLine());
                e[i].Date.Month = m;

                Console.Write("Enter year for the birth : ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                e[i].Date.Year = y;
                Console.ReadLine();
            }
        }

    }
}

/*
 * Output :
 
Create a nested structure and store data in an array :
--------------------------------------------------------
Enter Total no of employee you want to enter
1
Name of the employee : nikitha
Enter day of the birth : 28
Enter month of the birth : 05
Enter year for the birth : 2000
 */