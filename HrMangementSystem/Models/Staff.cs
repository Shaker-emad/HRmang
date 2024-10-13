namespace HrMangementSystem.Models
{
    public class Staff
    {
        public int StaffId { get; set; } // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } 
        public string Role { get; set; }
   }

}
