using Microsoft.EntityFrameworkCore;
using Persistance.Sqlite.Models;
using System;
using System.IO;
using System.Reflection;

namespace Persistance.Sqlite
{
    public class BalanceContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BalanceSheet> BalanceSheets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source=balancesheet.db");
            var ass = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var path = Path.Join(ass, "balancesheet.db");
            var dataStr = "Data Source=" + path;
            optionsBuilder.UseSqlite(dataStr);
        }


    }
}
