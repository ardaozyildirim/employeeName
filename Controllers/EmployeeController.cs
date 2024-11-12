using employeeName.DAL;
using employeeName.Models.DBEntities;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    private readonly EmployeeDbContext _context;

    public EmployeeController(EmployeeDbContext context)
    {
        _context = context;
    }

    // Display the create form
    public IActionResult Create()
    {
        return View();
    }

    // Handle form submission and create new employee
    [HttpPost]
    public IActionResult Create(Employee employee)
    {
        if (ModelState.IsValid)
        {
            try
            {
                _context.Employees.Add(employee);  // Add the employee to the database
                _context.SaveChanges();  // Save changes to the database
                TempData["Message"] = "Register successful";  // Store success message in TempData
                return RedirectToAction("Index");  // Redirect to the employee list
            }
            catch (Exception)
            {
                TempData["Message"] = "Something is wrong with your request";  // Error message
                return RedirectToAction("Index");  // Redirect to the employee list
            }
        }
        TempData["Message"] = "Something is wrong with your request";  // Error message
        return RedirectToAction("Index");
    }

}