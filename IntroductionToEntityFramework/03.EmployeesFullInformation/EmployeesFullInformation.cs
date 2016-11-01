namespace _03.EmployeesFullInformation
{
    using DatabaseFirst;
    using System;

    public class EmployeesFullInformation
    {
        public static void Main()
        {
            var context = new SoftUniContext();

            var employees = context.Employees;
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary}");
            }
        }
    }
}
