using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistance.Sqlite.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public string ImgLocation { get; set; }
        public string LinkedFiles { get; set; }
        public User Owner { get; set; }
    }
}
