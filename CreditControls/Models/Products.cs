namespace CreditControls.Models
{
    public class Products : BaseEntitie
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Catagories Category { get; set; }
        public double Price { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }
    }
}
