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

    // Display the form
    public IActionResult Create()
    {
        return View();
    }

    // Handle form submission and create a new employee
    [HttpPost]
    public IActionResult Create(Employee employee)
    {
        if (ModelState.IsValid)
        {
            try
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                TempData["Message"] = "Registration successful!";
                return RedirectToAction("Index"); // Ensure this redirects to the Index action
            }
            catch
            {
                TempData["Message"] = "Something went wrong.";
                return RedirectToAction("Create"); // Ensure this redirects to Create again
            }
        }
        return View(employee);
    }

    // Ensure this is correctly defined as a method
    public IActionResult Index()
    {
        var employees = _context.Employees.ToList(); // Fetch employees list
        ViewBag.Message = TempData["Message"];  // Retrieve message (success or error)

        // Null check for Email before passing to view
        foreach (var employee in employees)
        {
            if (employee.Email == null)
            {
                employee.Email = "N/A";  // Or handle accordingly if Email is null
            }
        }

        return View(employees);  // Pass the list of employees to the view
    }

    [HttpGet("api/Employee/List")]
    public IActionResult List()
    {
        var employees = _context.Employees.ToList(); // Fetch employees list

        // Null check for Email before passing to view
        foreach (var employee in employees)
        {
            if (employee.Email == null)
            {
                employee.Email = "N/A";  // Or handle accordingly if Email is null
            }
        }

        return Ok(employees);  // Pass the list of employees to the view
    }
}
