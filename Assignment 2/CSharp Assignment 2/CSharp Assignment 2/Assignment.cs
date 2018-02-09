using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment_2
{
    class Assignment
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Question No (1, 2):");
            string que = Console.ReadLine();

            Console.WriteLine("");
            if (que.Equals("1"))
            {
                Question1.Question11();
                Console.ReadKey();
            }
            else if (que.Equals("2"))
            {
                Question2.Question12();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Enter 1 or 2");
            }

        }
    }
}
