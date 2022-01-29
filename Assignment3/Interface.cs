using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
 3.Create an Interface IStudent with StudentId and Name as Properties, ShowDetails()
as its method. Create 2 classes Dayscholar and Resident that implements the interface
Properties and Methods. Test The functionalities.

Output:
Babbi is a Residential Student
Babbi has a Student ID : G985

Nithin is a Residential Student
Nithin has a Student ID : E873

Nikitha is a Dayscholar Student
Nikitha has a Student ID : Y378

Shivani is a Dayscholar Student
Shivani has a Student ID : Q278 

*/

namespace Assignment
{
    class Interface_student
    {
        interface IStudent
        {
            // Interfaces can contain properties and methods, but not fields/variables
            // Interface members are by default public. So no need to declare as public for methods/properties

            // Student id and name as properties inside method
            void ShowDetails(string Name, string S_id);

        }
        class Dayscholar : IStudent
        {
            // Giving the inputs student name and student id and dispalying
            public void ShowDetails(string Name, string S_id)
            {
                Console.WriteLine($"\n{Name} is a Residential Student");
                Console.WriteLine($"{Name} has a Student ID : {S_id}");
            }
        }
        class Resident : IStudent
        {
            // Giving the inputs student name and student id and dispalying
            public void ShowDetails(string Name, string S_id)
            {
                Console.WriteLine($"\n{Name} is a Dayscholar Student");
                Console.WriteLine($"{Name} has a Student ID : {S_id}");
            }
        }
        class Student
        {
            static void Main(string[] args)
            {
                // Giving inputs for student name id, name to method of Daysscholr. 
                Dayscholar d1 = new Dayscholar();
                d1.ShowDetails("Babbi","G985");

                Dayscholar d2 = new Dayscholar();
                d2.ShowDetails("Nithin","E873");

                // Giving inputs for student name id, name to method of Resident.
                Resident r1 = new Resident();
                r1.ShowDetails("Nikitha","Y378");

                Resident r2 = new Resident();
                r2.ShowDetails("Shivani","Q278");

                Console.Read();
            }
        }
    }
}


