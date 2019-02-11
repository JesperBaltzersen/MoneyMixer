using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistance.Sqlite;
using Persistance.Sqlite.Models;

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
            //var temp = new BloggingContext();
            //using (var db = new BloggingContext())
            //{
            //    db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
            //    var count = db.SaveChanges();
            //    foreach (var blog in db.Blogs)
            //    {
            //        Console.WriteLine(" - {0}", blog.Url);
            //    }
            //    var allBlogs = db.Blogs.ToList();
            //}

            using (var db = new BalanceContext())
            {
                db.Posts.Add(new Persistance.Sqlite.Models.Post { Amount = 100, Description = "hello", Id=new Guid() });
                var count = db.SaveChanges();
                foreach (var post in db.Posts)
                {
                    Console.WriteLine(" - {0}", post.Amount);
                    postsList.Add(new Post { Amount = post.Amount, Description = post.Description });
                }
                var temp = db.Posts.First();
                var allPosts = db.Posts.ToList();
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