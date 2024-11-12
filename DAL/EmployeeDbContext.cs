using Microsoft.EntityFrameworkCore;
using employeeName.Models.DBEntities;

namespace employeeName.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; } = default!;

    }
}
