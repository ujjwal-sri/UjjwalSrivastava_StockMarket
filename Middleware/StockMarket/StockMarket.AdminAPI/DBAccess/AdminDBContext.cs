using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StockMarket.AdminAPI.Models;

namespace StockMarket.AdminAPI.DBAccess
{
    public class AdminDBContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<StockPrice> Stockprices { get; set; }
        public DbSet<IPO> Ipos { get; set; }
        public DbSet<Company> Companies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer("Data Source=DESKTOP-6EEBF9S;Initial Catalog=StockMarketDB;User ID=sa;Password=pass@word1");
        }
    }
}
