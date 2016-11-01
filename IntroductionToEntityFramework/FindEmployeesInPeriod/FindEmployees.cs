namespace FindEmployeesInPeriod
{
    using System;
    using System.Linq;

    using DatabaseFirst;
  
    public class FindEmployees
    {
        public static void Main()
        {
            var context = new SoftUniContext();

            var employees = context.Employees
                .Where(e => e.Projects
                    .Count(p => p.StartDate.Year >= 2001 && p.StartDate.Year <= 2003) > 0)
                .Take(30);

            foreach (var empl in employees)
            {
                Console.WriteLine($"{empl.FirstName} {empl.LastName} {empl.Manager.FirstName}");
                foreach (var pr in empl.Projects)
                {
                    string format = "M/d/yyyy h:mm:ss tt";
                    string end = pr.EndDate.ToString();
                    Console.Write($"--{pr.Name} ");
                    Console.Write($"{pr.StartDate.ToString(format)} ");
                    Console.WriteLine($"{end}");
                }
            }
        }
    }
}
