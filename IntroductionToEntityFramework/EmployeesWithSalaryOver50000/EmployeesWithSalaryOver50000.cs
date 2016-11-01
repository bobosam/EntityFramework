namespace EmployeesWithSalaryOver50000
{
    using System;
    using System.Linq;

    using DatabaseFirst;

    public class EmployeesWithSalaryOver50000
    {
        public static void Main()
        {
            var context = new SoftUniContext();

            var employeesNames = context.Employees
                .Where(e => e.Salary > 50000)
                .Select(e => e.FirstName);

            foreach (var name in employeesNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
