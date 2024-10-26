using JediOrderApi.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace JediOrderApi.Data
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedDataAsync(ModelBuilder modelBuilder)
        {
            // Seed data for 'Products'
            var productsJson = await File.ReadAllTextAsync("Data/JediOrderDataSeed/products.json");
            var products = JsonSerializer.Deserialize<List<Products>>(productsJson);
            modelBuilder.Entity<Products>().HasData(products!);

            // Seed data for 'Reviews'
            var reviewsJson = await File.ReadAllTextAsync("Data/JediOrderDataSeed/reviews.json");
            var reviews = JsonSerializer.Deserialize<List<Reviews>>(reviewsJson);
            modelBuilder.Entity<Reviews>().HasData(reviews!);
        }
    }
}
