using JediOrderApi.Enums;
using JediOrderApi.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace JediOrderApi.Data
{
    public class JediOrderDbContext: DbContext
    {
        public JediOrderDbContext(DbContextOptions<JediOrderDbContext> dbContextOptions): base(dbContextOptions) 
        {
              
        }
        public  DbSet<Products> Product { get; set; }
        public  DbSet<Reviews> Review { get; set; }
        public  DbSet<Images> Image { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure 'Products' entity
            modelBuilder.Entity<Products>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Products>()
                .HasIndex(p => p.Name)
                .IsUnique();
            
            // Call the seed method
            ApplicationDbContextSeed.SeedDataAsync(modelBuilder).GetAwaiter().GetResult();           
        }

    }
}
