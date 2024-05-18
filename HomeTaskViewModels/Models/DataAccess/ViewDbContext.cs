using Microsoft.EntityFrameworkCore;

namespace HomeTaskViewModels.Models.DataAccess
{
	public class ViewDbContext:DbContext
	{
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<ProductsToSpecification> ProductsToSpecifications { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Specifications> Specifications { get; set; }
        public ViewDbContext(DbContextOptions<ViewDbContext> options) : base(options) { }

    }
}
