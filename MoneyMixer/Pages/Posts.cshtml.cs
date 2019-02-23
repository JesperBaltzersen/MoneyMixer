using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistance.Sqlite;
using Persistance.Sqlite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

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

        private IHostingEnvironment _hostingEnvironment;

        public PostsModel(IHostingEnvironment environment)
        {
            _hostingEnvironment = environment;
        }

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

        public IActionResult OnPost(Post post)
        {
            if (ModelState.IsValid)
            {
                if (post.Image != null)
                {
                    //var file = Path.Combine(_hostingEnvironment.ContentRootPath, "uploads");
                }

                using (var db = new BalanceContext())
                {
                    post.CreateDate = DateTime.Now;
                    db.Posts.Add(post);
                    var count = db.SaveChanges();
                    // return success/failure based on adding post
                    // return updated list of posts
                    // clear input form if successful       
                }
                return RedirectToPage("Posts");
            }


            return Page();
        }
    }
}