namespace HomeTaskViewModels.Models
{
    public class ProductsToSpecification
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Products? Products { get; set; }
        public int SpecificationId { get; set; }
        public Specifications? Specifications { get; set; }
    }
}
