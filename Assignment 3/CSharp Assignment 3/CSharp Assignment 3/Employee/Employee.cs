using System;

namespace CSharp_Assignment_3.Employee
{
    public abstract class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Experience { get; set; }
        public DateTime JoiningDate { get; set; }
        public double AnnualSalary { get;  set; }

        public abstract double getAnnualSalary(double basicSalary);

        public virtual void PrintEmp()
        {
            Console.WriteLine(String.Format("Id: {0}\n" +
                                 "Name: {1}\n" +
                                 "Designation: {2}\n" +
                                 "Experience: {3} Years\n" +
                                 "Joining Date: {4}\n" +
                                 "Annual Salary: {5} RS",
                                Id, Name, Designation, Experience, JoiningDate.ToShortDateString(), AnnualSalary));
        }
    }
}
