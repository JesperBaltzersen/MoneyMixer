using Persistance.Sqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistance.Sqlite
{
    public class BalanceService
    {

        public bool AddPostToBalanceSheet(Post post)
        {
            int count = 0;
            using (var db = new BalanceContext())
            {
                var state = db.Posts.Add(post);
                count = db.SaveChanges();


            }
            return count > 0;
        }

        public bool RemovePostFromBalanceSheet(Post post)
        {
            int count = 0;
            using (var db = new BalanceContext())
            {
                var result = db.Posts.Remove(post);
                count = db.SaveChanges();
            }

            return count > 0;
        }

        public IEnumerable<Post> GetPosts()
        {
            IQueryable<Post> data;
            using (var db = new BalanceContext())
            {
                data = db.Posts.Where(p => p.Amount > 1);
                data.ToList();
            }
            return data;
        }


    }
}
