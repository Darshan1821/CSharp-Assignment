using System;

namespace CSharp_Assignment
{
    class Assignment
    {
        static void Main(string[] args)
        {
            Console.Write("View Question (1, 2, 3): ");
            string que = Console.ReadLine();

            Console.WriteLine("");
            if ( que.Equals("1") )
            {
                Question1.Question11();
                Console.ReadKey();
            }
            else if ( que.Equals("2") )
            {
                Question2.Question12();
                Console.ReadKey();
            }
            else if(que.Equals("3"))
            {
                Question3.Question13();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Enter 1, 2 or 3.");
                Console.ReadKey();
            }
        }
    }
}
