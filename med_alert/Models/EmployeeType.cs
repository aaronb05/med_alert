namespace med_alert.Models
{
    public class EmployeeType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }



        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
