using System;

namespace CSharp_Assignment_3.Employee
{
    class EmployeeManagement
    {
        public static void ManageEmployees()
        {
            Employee employee = null;

            AddEmployees(employee);
        }

        private static void AddEmployees(Employee employee)
        {
            double basicSalary = 8000;

            employee = new HR() { Id="E001", Name="Rohan Asrani", Experience=4, JoiningDate=new DateTime(2014, 2, 12) };
            employee.AnnualSalary = employee.getAnnualSalary(basicSalary);
            employee.PrintEmp();

            Console.WriteLine("");
            employee = new Developer() { Id = "E002", Name = "John Doe", Experience = 5, JoiningDate = new DateTime(2013, 2, 12) };
            employee.AnnualSalary = employee.getAnnualSalary(basicSalary);
            employee.PrintEmp();
        }
    }
}
