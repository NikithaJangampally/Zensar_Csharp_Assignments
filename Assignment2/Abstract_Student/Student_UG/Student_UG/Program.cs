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

   
    abstract class Abstract_Student
    {
        public string Name = "Nikitha";
        public int StudentId = 840;

        public abstract Boolean Ispassed(float grade);

    }

    class UGraduate : Abstract_Student
    {

        public override bool Ispassed(float grade)
        {
            Console.Write("UnderGraduation:  ");
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

    class Graduate : Abstract_Student
    {
        public override bool Ispassed(float grade)
        {
            Console.Write("Graduation:  ");
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
            bool p;
            UGraduate ug = new UGraduate();
            Console.WriteLine("Student Name is: " + ug.Name);
            Console.WriteLine("Student Idno is: " + ug.StudentId);
            p = ug.Ispassed(67.3f);
            if (p)
            {
                Console.WriteLine("In Undergraduation, the Student has Passed");
            }
            else
                Console.WriteLine("In Undergraduation, the Student has Failed");

            Graduate gr = new Graduate();
            p = gr.Ispassed(87.2f);
            if (p)
            {
                Console.WriteLine("In Graduation, the Student has Passed ");
            }
            else
                Console.WriteLine("In Graduation, the Student has Failed ");

        }



    }
    
}
