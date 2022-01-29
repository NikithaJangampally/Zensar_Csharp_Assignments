using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Structure :

 4. Write a program in C# Sharp to declare a structure called Books with a property, a method to display the
 value of Book_id, and a private field called Book_id (int)

 Output:
 Enter the name :
 Nikitha
 Enter the Book Id:
 298712
 Author name is : Nikitha
 Book Id is : 298712

 */

namespace Assignment
{
    //Declaring Structure
    struct Books{
        private int Book_id; 
        public string Name;

        //Property called Id for getting and setting value in structure from main
        public int Id
        {
            get { return Book_id; }
            set { Book_id = value; }
        }
        // A method to display the name (Optional)
        public void Data(string Name)
        {
            Console.WriteLine("Author name is : "+Name);
        }
        // A method to display value of Book_id
        public void BookDetails(int Book_id)
        {
            Console.WriteLine("Book Id is : " + Book_id);
        }
    }
    class Structure
    {
        public static void Main()
        {
            //Calling the constructor of Structure (Books)
            Books B = new Books();

            Console.WriteLine("Enter the name : ");
            B.Name = Console.ReadLine();

            Console.WriteLine("Enter the Book Id: ");
            B.Id = Convert.ToInt32(Console.ReadLine());

            B.Data(B.Name);
            B.BookDetails(B.Id);
            Console.ReadLine();
        }
    }
}
