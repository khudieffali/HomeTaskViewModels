using System.Globalization;

namespace HomeTaskViewModels.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagePath  { get; set; }
        public bool IsDiscount { get; set; }
        public decimal? DiscountPrice { get; set; }
        public int Raiting { get; set; }
        public int ViewCount { get; set; }
        public int CategoryId { get; set; }
        public Categories? Categories { get; set; }

    }
}
