using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employeeName.Models.DBEntities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; } // Add this propert



        // Add this FullName property to combine FirstName and LastName
        public string FullName => $"{FirstName} {LastName}";
    }


}
