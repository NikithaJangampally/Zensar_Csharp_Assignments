using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 3.Create an Abstract class Student with  Name, StudentId, Grade as members and also an abstract method Boolean Ispassed(grade) which takes grade as an input and checks whether student passed the course or not.  

Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed() method 

For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false. For the Grad class, if the grade is above 80.0, then isPassed returns true, otherwise returns false.

*/

namespace Student_UG { 

   
    abstract class Studentabs
    {
        public string Name = "Nikitha";
        public int StudentId = 840;

        public abstract Boolean Ispassed(float grade);

    }

    class UGraduate : Studentabs
    {

        public override bool Ispassed(float grade)
        {
            Console.Write("UnderGraduate:  ");
            if (grade > 70.0f)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }

    class Graduate : Studentabs
    {
        public override bool Ispassed(float grade)
        {
            Console.Write("Graduate:  ");
            if (grade > 80.0f)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

    class Abstract_Class
    {
        public static void Main(string[] args)
        {
            bool pass;
            UGraduate u = new UGraduate();
            Console.WriteLine("Student Name is: " + u.Name);
            Console.WriteLine("Student Idno is: " + u.StudentId);
            pass = u.Ispassed(80.0f);
            if (pass)
            {
                Console.WriteLine("The Student is passed in UnderGraduate");
            }
            else
                Console.WriteLine("The Student is Failed in UnderGraduate");

            Graduate g = new Graduate();
            pass = g.Ispassed(71.0f);
            if (pass)
            {
                Console.WriteLine("The Student is passed in Graduate");
            }
            else
                Console.WriteLine("The Student is Failed in Graduate");

        }



    }
    
}
