using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employeeName.Models.DBEntities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required, EmailAddress]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("Salary")]
        public double? Salary { get; set; }

        [DisplayName("Full Name")]
        public string FullName => $"{FirstName} {LastName}";
    }
}
