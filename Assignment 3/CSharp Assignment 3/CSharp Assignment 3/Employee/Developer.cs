using System;

namespace CSharp_Assignment_3.Employee
{
    class Developer : Employee
    {
        public Developer()
        {
            Designation = "Developer";
        }

        public override double getAnnualSalary(double basicSalary)
        {
            return basicSalary + (2000 * Experience);
        }

        public override void PrintEmp()
        {
            Console.WriteLine("Developer:\n");
            base.PrintEmp();
        }
    }
}
