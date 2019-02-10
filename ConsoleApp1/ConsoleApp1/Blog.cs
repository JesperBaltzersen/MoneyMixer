using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public ICollection<PostBlog> Posts { get; set; }
    }
}
