﻿
using ETicaret.Model;
using ETicaret.Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ETicaretWebUI.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
        public DbSet<Category> Kategoriler { get; set; }
        public DbSet<Product> Urunler { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1,Name="Aksiyon",DisplayOrder=1},
                new Category { Id=2, Name="Bilim-Kurgu",DisplayOrder=2},
                new Category { Id=3, Name="Tarih",DisplayOrder=3}
            
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Kumaş Baggy Pantolon",
                    Author = "WEET8998",
                    Description = "Kumaş Baggy Pantolon İndigo ST00122-Siyah",
                    ISBN = "ST00122-Siyah",
                    ListPrice = 550.99,
                    Price = 529.99,
                    Price50 = 509.99,
                    Price100 = 500,
                    CategoryId =1,
                },
                 new Product
                 {
                     Id = 2,
                     Title = "United Kingdom Oversize",
                     Author = "STRE6655",
                     Description = "Studios Ltd. United Kingdom Oversize T-Shirt Beyaz",
                     ISBN = "ST00275-Beyaz",
                     ListPrice = 449.99,
                     Price = 429.99,
                     Price50 = 410.99,
                     Price100 = 400,
                     CategoryId =2,
                 }


                );

            
        }
    }
}
