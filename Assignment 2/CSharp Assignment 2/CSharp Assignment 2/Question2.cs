using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment_2
{
    class Question2
    {
        public static void Question12()
        {


            float x = 0.06f;
            float y = 5.94f;

            Console.WriteLine("x: " + x + ", y: " + y + "\n");

            Console.WriteLine("Sum of x & y: " + (x+y));
            Console.WriteLine("------------------------------------------------------------------------------");

            if ((x+y).Equals(6))
            {
                Console.WriteLine("x + y = 6");
            }
            else
            {
                Console.WriteLine("x + y != 6");
            }
            Console.WriteLine("------------------------------------------------------------------------------");

            int comp = x.CompareTo(y);
            if (comp == 0)
            {
                Console.WriteLine("x and y are equals.");
            }
            else
            {
                if (comp == -1)
                    Console.WriteLine("x < y");
                else
                    Console.WriteLine("x > y");
            }
        }
    }
}
