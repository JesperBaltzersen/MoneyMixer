using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using Persistance.Sqlite;
using Persistance.Sqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
            using (var db = new BalanceContext())
            {
                foreach (var p in db.Posts)
                {
                    postsList.Add(p);
                }
            }
            postsList.Reverse();
        }

        public void OnPost(Post post)
        {
         
            using (var db = new BalanceContext())
            {
                post.CreateDate = DateTime.Now;
                db.Posts.Add(post);
                var count = db.SaveChanges();
                // return success/failure based on adding post
                // return updated list of posts
                // clear input form if successful
                
            }
        }
    }
}