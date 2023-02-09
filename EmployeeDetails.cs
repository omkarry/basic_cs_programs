using System;

namespace IBasic
{
    public class EmployeeDetails
    {
        
        public static void Main(string[] args)
        {
            int employeeId, age, salary;
            string employeeName;            

            employeeId = Convert.ToInt16(Console.ReadLine());
            employeeName = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            salary = Int32(Console.ReadLine());

            Console.WriteLine("----------Employee Details---------");
            Console.WriteLine($"Id: {employeeId}");
            Console.WriteLine($"Name: {employeeName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Salary: {salary}");
        }
    }
}