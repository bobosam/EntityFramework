namespace _05.EmployeesFromSeattle
{
    using System;
    using System.Linq;

    using DatabaseFirst;

    public class EmployeesFromSeattle
    {
        public static void Main()
        {
            var context = new SoftUniContext();

            var employees = context.Employees
                .Where(e => e.Department.Name == "Research and Development")
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName);

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} " +
                    $"from {employee.Department.Name} - ${employee.Salary:F2}");
            }
        }
    }
}
