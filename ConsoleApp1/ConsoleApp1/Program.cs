﻿using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            var test = new BloggingService();
            test.TestSqlite();
            //using (var db = new BloggingContext())
            //{
            //    db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
            //    var count = db.SaveChanges();
            //    Console.WriteLine("{0} records saved to database", count);

            //    Console.WriteLine();
            //    Console.WriteLine("All blogs in database:");
            //    foreach (var blog in db.Blogs)
            //    {
            //        Console.WriteLine(" - {0}", blog.Url);
            //    }
            //    var allBlogs = db.Blogs.ToList();
            //    Console.ReadLine();
            //}
        }
    }
}