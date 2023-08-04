using HPlussSport.API.Models;
using Microsoft.EntityFrameworkCore;



namespace HPlusSport.API.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder ) 
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Active Wear - Men" },
                new Category { Id = 2, Name = "Active Wear - Women" },
                new Category { Id = 3, Name = "Mineral Water" },
                new Category { Id = 4, Name = "Publications" },
                new Category { Id = 5, Name = "Supplements" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Jogstrap" },
                new Product { Id = 2, CategoryId = 1, Name = "Baseball cap" },
                new Product { Id = 3, CategoryId = 2, Name = "Sneaker" },
                new Product { Id = 4, CategoryId = 2, Name = "Headband" },
                new Product { Id = 5, CategoryId = 2, Name = "Support bra" },
                new Product { Id = 6, CategoryId = 3, Name = "Electrolite" },
                new Product { Id = 7, CategoryId = 3, Name = "Gatorate" },
                new Product { Id = 8, CategoryId = 4, Name = "Chi Running" },
                new Product { Id = 9, CategoryId = 4, Name = "Tour De France" },
                new Product { Id = 10, CategoryId = 5, Name = "Seaweed Bar" },
                new Product { Id = 11, CategoryId = 5, Name = "B12 Xperformance" },
                new Product { Id = 12, CategoryId = 5, Name = "BioBoostTonage" }
                );
                
        }
    }
}
