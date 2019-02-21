using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistance.Sqlite;
using Persistance.Sqlite.Models;
using System;

namespace Delonomi.Pages
{
    public class PostInfoModel : PageModel
    {
        [BindProperty]
        public Post Post { get; set; }

        public IActionResult OnGet(Guid id)
        {
            using (var db = new BalanceContext())
            {
                Post = db.Posts.Find(id);

            }

            return Page();
        }
    }
}