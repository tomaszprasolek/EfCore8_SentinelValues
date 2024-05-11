using EfCore8_SentinelValues.Database;
using Microsoft.EntityFrameworkCore;

using var db = new MyContext();
db.Database.Migrate();

AddCustomer(new Customer {Name = "Default values, points: 10"});
AddCustomer(new Customer {Name = "Zero points", Points = 0 });
AddCustomer(new Customer {Name = "-1 points", Points = -1});
AddCustomer(new Customer {Name = "-2 points", Points = -2});

Console.WriteLine("All customers:");
var allCustomers = db.Customers.ToList();
foreach (Customer customer in allCustomers)
{
    Console.WriteLine(customer.ToString());
    
}

return;

void AddCustomer(Customer customer)
{
    db.Add(customer);
    db.SaveChanges();
}