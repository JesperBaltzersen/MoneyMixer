using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistance.Sqlite;
using Persistance.Sqlite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public async Task<IActionResult> OnPost(Post post)
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

                var jason = await GetPostImage(post.Image);

                return RedirectToPage("Posts");
            }


            return Page();
        }

        public async Task<IActionResult> GetPostImage(IFormFile image)
        {
            var imagePath = _hostingEnvironment.WebRootFileProvider.GetFileInfo("images/").PhysicalPath;
            // full path to file in temp location
            var filePath = Path.GetTempFileName();
            if (image.Length > 0)
            {
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }
            }


            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return new JsonResult("JSON");
        }

        [HttpPost]
        public async Task<IActionResult> AddImage(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return new JsonResult("new jason");
        }
    }
}