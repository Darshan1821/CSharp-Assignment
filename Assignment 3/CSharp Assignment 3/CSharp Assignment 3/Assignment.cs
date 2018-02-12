using System;

namespace CSharp_Assignment_3
{
    class Assignment
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Question (1,2): ");
            string ques = Console.ReadLine();

            Console.WriteLine("");
            if (ques.Equals("1"))
            {
                Product.ProductManagement.ManageProducts();
                Console.ReadKey();
            }
            else if (ques.Equals("2"))
            {
                Employee.EmployeeManagement.ManageEmployees();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Enter 1 or 2.");
                Console.ReadKey();
            }
        }
    }
}
