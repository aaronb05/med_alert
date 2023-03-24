using Microsoft.AspNetCore.Identity;

namespace med_alert.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public string Status { get; set; }
        public int DepartmentId { get; set; }
        public int EmployeeTypeId { get; set; }



        public virtual ICollection<IdentityRole> Roles { get; set; }
    }
}
