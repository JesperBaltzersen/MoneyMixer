using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ConsoleApp1
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<PostBlog> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ass = Assembly.GetExecutingAssembly();
            
            optionsBuilder.UseSqlite("Data Source=blogging.db");
        }
    }
}
