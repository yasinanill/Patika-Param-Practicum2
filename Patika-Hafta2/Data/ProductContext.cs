using Microsoft.EntityFrameworkCore;

namespace Patika_Hafta1_Odev.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {



        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new() { Id = 1,Name= "Bilgisayar", CreateDate = System.DateTime.Now.AddDays(-3), Price=20000, Stock= 300},
                 new() { Id = 3,Name= "Telefon", CreateDate = System.DateTime.Now.AddDays(-3), Price=12000, Stock= 3200},
                 new() { Id = 4,Name= "Klavye", CreateDate = System.DateTime.Now.AddDays(-3), Price=1000, Stock= 3200},
            }


                ) ;


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }

    }
}
