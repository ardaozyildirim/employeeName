using Microsoft.AspNetCore.Mvc;
using employeeName.DAL;
using employeeName.Models.DBEntities;


namespace EmployeeData.Controllers
{
    public class EmployeeController : Controller 
    {

        private readonly EmployeeDbContext _context;
     public EmployeeController(EmployeeDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }
    }
}