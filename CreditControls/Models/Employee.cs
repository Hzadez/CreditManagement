
namespace CreditControls.Models
{
    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
