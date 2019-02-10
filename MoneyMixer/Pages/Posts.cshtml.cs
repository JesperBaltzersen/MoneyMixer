using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1;
using Delonomi.Models;
//using Delonomi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Delonomi.Pages
{
    public class PostsModel : PageModel
    {
        public List<Post> postsList = new List<Post> {
            new Post { Amount = -100, Description = "Michela" },
            new Post { Amount = 100, Description = "Jesper" }
        };
    
        [BindProperty]
        public Post Post { get; set; }

        public void OnGet()
        {
            //var client = new BalanceSheetClient();
            //postsList =  client.GetPosts().ToList();
            //client.AddPost(new Post { Amount = 100, Description = "lsfdjk" });
            //using (var db = new BalanceContext())
            //{

            //}
            var temp = new BloggingContext();
            using (var db = new BloggingContext())
            {
                db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                var count = db.SaveChanges();
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(" - {0}", blog.Url);
                }
                var allBlogs = db.Blogs.ToList();
            }
        }

        public void OnPost(Post post)
        {
            //postsList.Add(post);
            //var client = new BalanceSheetClient();
            //client.AddPost(post);
        }
    }
}