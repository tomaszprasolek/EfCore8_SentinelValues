using EfCore8_SentinelValues.Database;
using Microsoft.EntityFrameworkCore;

using var db = new MyContext();
db.Database.Migrate();

var newCustomer = new Customer {Name = "Default values"};
db.Add(newCustomer);
db.SaveChanges();

newCustomer = new Customer {Name = "Zero points", Points = 0 };
db.Add(newCustomer);
db.SaveChanges();

Console.WriteLine("All customers:");
var allCustomers = db.Customers.ToList();
foreach (Customer customer in allCustomers)
{
    Console.WriteLine(customer.ToString());
    
}

//Console.ReadKey();