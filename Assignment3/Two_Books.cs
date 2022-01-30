using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 6. Write a program in C# Sharp to insert the information of two books. 

Test Data :

Insert the information of two books :                    
-----------------------------------------                
Information of book 1 :                                  
Input name of the book : BASIC                           
Input the author : S.TROELSTRA                           
                                                         
Information of book 2 :                                  
Input name of the book : C+                              
Input the author : G.RTRTG   

                            
Expected Output:

1: Title = BASIC,  Author = S.TROELSTRA                  
                                                         
2: Title = C+,  Author = G.RTRTG 

 */

namespace Assignment3
{
    struct Book
    {
        public string name;
        public string author;
    }
    class Two_Books
    {
        public static void Main()
        {
            int b = 10;
            Book[] books = new Book[b];
            int i, j, n = 1, k = 1;
            Console.WriteLine("Insert The Information of Two Books.");
            for (j = 0; j <= n; j++)
            {
                Console.WriteLine("Information of book : {0} ", k);

                Console.Write("Input name of the book : ");
                books[j].name = Console.ReadLine();

                Console.Write("Input the author : ");
                books[j].author = Console.ReadLine();
                k++;
                Console.WriteLine();
            }
            for (i = 0; i <= n; i++)
            {
                Console.WriteLine($"{i + 1}: Title = {books[i].name}, Author = {books[i].author}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
/*
 Output:

Insert The Information of Two Books.
Information of book : 1
Input name of the book : BASIC
Input the author : S.TROELSTRA

Information of book : 2
Input name of the book : c+
Input the author : G.RTRTG

1: Title = BASIC,  Author = S.TROELSTRA

2: Title = c+,  Author = G.RTRTG
*/
