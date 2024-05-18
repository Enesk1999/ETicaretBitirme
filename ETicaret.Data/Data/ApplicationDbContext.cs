
using ETicaret.Model;
using Microsoft.EntityFrameworkCore;

namespace ETicaretWebUI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
        public DbSet<Category> Categoriler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1,Name="Aksiyon",DisplayOrder=1},
                new Category { Id=2, Name="Bilim-Kurgu",DisplayOrder=2},
                new Category { Id=3, Name="Tarih",DisplayOrder=3}
            
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
