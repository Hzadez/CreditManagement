namespace CreditControls.Models
{
    public class Merchant : BaseEntitie
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Branch> Branches { get; set; }
    }
}
