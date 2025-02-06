
using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.Interface;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock
{
    public class DataContext : DbContext, IContext
    {
        public DbSet<Category> Categories { get; set ; }
        public DbSet<Product> Products { get ; set ; }
        public DbSet<Order> Orders { get ; set ; }
      

        public async Task Save()
        {
            await SaveChangesAsync();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=dc2016\\erasql;database=productDb;trusted_connection=true;TrustServerCertificate=True");
        }
    }
}
