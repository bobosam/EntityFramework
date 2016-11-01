namespace AddingANewAddressAndUpdatingEmployee
{
    using System;
    using System.Linq;

    using DatabaseFirst;
    using DatabaseFirst.Models;

    public class AddingAddress
    {
        public static void Main()
        {
            var context = new SoftUniContext();

            var address = new Address()
            {
                AddressText = "Vitoshka 15",
                TownID = 4
            };

            Employee employee = null;
            employee = context.Employees
                .FirstOrDefault(e => e.LastName == "Nakov");

            employee.Address = address;

            context.SaveChanges();

            var employees = context.Employees
                .OrderByDescending(e => e.AddressID)
                .Take(10);

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Address.AddressText}");
            }
        }
    }
}
