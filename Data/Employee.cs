using System.ComponentModel.DataAnnotations;

namespace EmployeeCrudBlazor.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public  required string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";


        public string ?PostalCode { get; set; }
        public required string  Address { get; set; }
        public  required string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public  required string Designation { get; set; }

    }
}
