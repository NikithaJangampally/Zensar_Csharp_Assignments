using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1. Write a program to find the Sum and the Average points scored by the teams in the IPL.
 Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches)
 that takes no.of matches as input and accepts that many scores from the user. The function
 should then display the Average and Sum of the scores

Output:

Enter number of matches:
3
Enter the Match1 score :
89
Enter the Match2 score :
65
Enter the Match3 score :
58
The Number of matches in IPL is/are: 3
The Total (sum) score of 3 matches:212
The Average Score of 3 Matches: 70

 */

namespace Assignment4
{
    class Cricket
    {
        public int Avg, Sum = 0;
        public int[] Score = new int[100];

        public void PointsCalculation(int no_of_matches)
        {
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.WriteLine("Enter the Match{0} score :", i+1);
                Score[i] = Convert.ToInt32(Console.ReadLine());
                Sum += Score[i];
            }
            Avg = Sum / no_of_matches;
            Console.WriteLine("The Number of matches in IPL is/are: {0}",no_of_matches);
            Console.WriteLine("The Total (sum) score of {0} matches:{1}",no_of_matches, Sum);
            Console.WriteLine("The Average Score of {0} Matches: {1}",no_of_matches, Avg);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Cricket cricket = new Cricket();
            Console.WriteLine("Enter number of matches:");
            n = Convert.ToInt32(Console.ReadLine());
            cricket.PointsCalculation(n);
        }
    }
}
