namespace employeeName.Models
{
    public class Employee  // Correct the model name to Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
    }
}