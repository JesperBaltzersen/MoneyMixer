using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Delonomi.Pages
{
    public class PostsModel : PageModel
    {
        public List<string> postsList = new List<string>{"-100", "+100"};
        public void OnGet()
        {
            
        }
    }
}