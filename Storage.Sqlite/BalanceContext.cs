using Microsoft.EntityFrameworkCore;
using Persistance.Sqlite.Models;
using System;

namespace Persistance.Sqlite
{
    public class BalanceContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BalanceSheet> BalanceSheets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=balancesheet.db");
        }
    }
}
