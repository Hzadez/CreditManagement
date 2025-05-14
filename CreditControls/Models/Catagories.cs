namespace CreditControls.Models
{
    public class Catagories : BaseEntitie
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
