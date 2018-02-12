using System;

namespace CSharp_Assignment_3.Employee
{
    public class HR : Employee
    {
        public HR()
        {
            Designation = "HR";
        }

        public override double getAnnualSalary(double basicSalary)
        {
            return basicSalary + (1000 * Experience);
        }

        public override void PrintEmp()
        {
            Console.WriteLine("HR:\n");
            base.PrintEmp();
        }
    }
}
