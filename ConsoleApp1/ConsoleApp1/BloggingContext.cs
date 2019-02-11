using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;

namespace ConsoleApp1
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<PostBlog> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ass = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var path = Path.Join(ass, "blogging.db");
            var dataStr = "Data Source=" + path;
            optionsBuilder.UseSqlite(dataStr);
        }
    }
}
