using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HrMangementSystem.Models
{

    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; } // Primary Key
        public string FirstName { get; set; }
        [Display(Name = "Profile Image")]
        public string Image { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        //Foreign Key

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        // Add navigation property for PerformanceProgresses
        public ICollection<PerformanceProgress> PerformanceProgresses { get; set; }
    }


}

