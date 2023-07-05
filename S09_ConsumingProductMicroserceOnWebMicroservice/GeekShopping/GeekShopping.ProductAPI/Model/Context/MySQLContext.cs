using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Random random = new();
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Camiseta Dragon Ball",
                Price = Convert.ToDecimal(random.NextDouble() * 100),
                Description = "DESCRIPTION RANDON",
                ImageUrl = "https://github.com/aarondmt/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Camiseta Elon Musck Sapcex",
                Price = Convert.ToDecimal(random.NextDouble() * 100),
                Description = "DESCRIPTION RANDON",
                ImageUrl = "https://github.com/aarondmt/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Camiseta GNU Linux",
                Price = Convert.ToDecimal(random.NextDouble() * 100),
                Description = "DESCRIPTION RANDON",
                ImageUrl = "https://github.com/aarondmt/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camista Mars",
                Price = Convert.ToDecimal(random.NextDouble() * 100),
                Description = "DESCRIPTION RANDON",
                ImageUrl = "https://github.com/aarondmt/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Camiseta Gamer",
                Price = Convert.ToDecimal(random.NextDouble() * 100),
                Description = "DESCRIPTION RANDON",
                ImageUrl = "https://github.com/aarondmt/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg",
                CategoryName = "T-shirt"
            });
        }
    }
}
