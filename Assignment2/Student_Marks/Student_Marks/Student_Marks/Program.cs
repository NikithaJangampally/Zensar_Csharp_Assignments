using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
  2. Create a class called student which has data members like rollno, name,
  class, SEM, branch,int [] marks=new int marks [5](marks of 5 subjects )

-Write a method called displayresult, which should calculate the average marks
-If marks of any one subject is less than 35 print result as failed
-If marks of all subject is >35 but average is < 50 then also print result as failed
-If avg > 50 then print result as passed.
-Pass the details of student like rollno, name, class, SEM, branch in constructor
-Write a Display Data method to display all values.

 */

namespace Student_Marks
{
    class Student
    {
        string name, branch, Class;
        int i, rollno, SEM, avg, sum = 0;
        int[] marks = new int[5];
        public Student(int roll_No, string Name, string cls, int s, string b)
        {
            rollno = roll_No;
            name = Name;
            Class = cls;
            SEM = s;
            branch = b;
        }
        public void displayresult()
        {
            for (i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("\nEnter the Subject {0} marks : ", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            avg = sum / marks.Length;
            Console.WriteLine($"\nAverage marks of the student {avg}");

            for (i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine($"\nThe student result in subject{i+1} is fail");
                }
                else if ((marks[i] > 35) && (avg < 50))
                {
                    Console.WriteLine($"\nThe Student result in subject{i+1} is fail");
                }
                else
                {
                    Console.WriteLine($"\nThe Student result in subject{i+1} is Pass");
                }
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("\nEnter the Student Details : ");
            Console.WriteLine($"\nEnter Roll no :{rollno}, Name : {name}, Class : {Class}, Semester : {SEM}, Branch : {branch}");
            Console.WriteLine("\nEnter the marks of the student : ");
            displayresult();
        }

        static void Main()
        {
            Student s = new Student(840, "Nikitha", "Four Year", 8, "CSE");
            s.DisplayData();
        }
    }
}

