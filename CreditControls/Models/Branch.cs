namespace CreditControls.Models
{
    public class Branch : BaseEntitie
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int MerchantId { get; set; }
        public Merchant Merchant { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
