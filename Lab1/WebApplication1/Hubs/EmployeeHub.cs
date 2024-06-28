using Microsoft.AspNetCore.SignalR;
using WebApplication1.Models;

namespace WebApplication1.Hubs
{
    public class EmployeeHub : Hub
    {
        EmployeeContext db;
        public EmployeeHub(EmployeeContext _db) 
        {
            db = _db;
        }
        // Method to add an employee
        public void addemployee(string name, string address, int age)
        {
            var employee = new Employee { Name = name, Address = address, Age = age };
            db.Employees.Add(employee);
            db.SaveChangesAsync();
           
            // Broadcast the newly added employee to all clients
            Clients.All.SendAsync("receiveemployee", employee);
            
        }
   
}
}
