namespace DeleteProjectById
{
    using System;
    using System.Linq;

    using DatabaseFirst;
   
    public class Program
    {
        public static void Main()
        {
            var context = new SoftUniContext();

            var project = context.Projects.Find(2);
            var employees = context.Employees;
            foreach (var employee in employees)
            {
                employee.Projects.Remove(project);
            }

            context.SaveChanges();

            context.Projects.Remove(project);
            context.SaveChanges();

            var projects = context.Projects.Take(10);
            foreach (var pr in projects)
            {
                Console.WriteLine(pr.Name);
            }
        }
    }
}
