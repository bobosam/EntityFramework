namespace AddressesByTownName
{
    using System;
    using System.Linq;

    using DatabaseFirst;

    public class AddressesByTownName
    {
        public static void Main()
        {
            var context = new SoftUniContext();

            var addresses = context.Addresses
                .OrderByDescending(a => a.Employees.Count)
                .ThenBy(a => a.Town.Name)
                .Take(10);

            foreach (var address in addresses)
            {
                Console.WriteLine($"{address.AddressText}, {address.Town.Name} - {address.Employees.Count} employees");
            } 
        }
    }
}
