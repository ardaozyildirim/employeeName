using System;
using employeeName.Models.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace employeeName.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }  // Ensure Employee model is available here


        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

    }
}
