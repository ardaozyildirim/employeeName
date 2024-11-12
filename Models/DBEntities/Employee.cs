using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using employeeName.Models.DBEntities;

namespace employeeName.Models.DBEntities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "Varchar(50)")]
        [DisplayName("First Name")]
        public string? FirstName { get; set; }

        [DisplayName("Last Name")]
        public string? LastName { get; set; }

        [DisplayName("Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [DisplayName("E-mail")]
        public string? Email { get; set; }

        [DisplayName("Salary")]
        public double? Salary { get; set; }

        [DisplayName("Full Name")]
        public string? FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
