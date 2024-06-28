using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext context;
        public EmployeeController(EmployeeContext _context)
        {
            context=_context;
        }
        public IActionResult Index()
        {
            var emplyees=context.Employees.ToList();
            return View("Index",emplyees);
        }
        public IActionResult AddEmploee()
        {
            
            return View("TableAllEmployee");
        }
    }
}
