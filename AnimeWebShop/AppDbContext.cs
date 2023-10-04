using AnimeWebShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeWebShop
{
    internal class AppDbContext: DbContext
    {
        public DbSet<Item> Items { get; set; }
        public AppDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql("server=localhost;port=3306;username=root;password=root;database=wpfshop");
        }
    }
}
