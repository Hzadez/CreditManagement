using CreditControls.Models;

namespace CreditControls.ViewModels
{
    public class BranchViewModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int MerchantId { get; set; }
        public Merchant Merchant { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
