using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Core.Entities.Concrete;


namespace DataAccess.Concrete.EntityFramework.Context
{
    //Context : db tabloları ile proje classlarını bağlamak ilişkiler ile 
    public class MoviesContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

       => optionsBuilder.UseNpgsql("Host=localhost:Database=Movies;Username=postgres;Password=12345"); // Entity framework çalışcağı zaman ben nereye bağlancam diyor 


        public DbSet<Genre> Movies { get; set; } //Hangi classım hangi tabloya karşılık gelicek
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }




    }
}