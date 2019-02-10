//using Delonomi.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;


//namespace Delonomi.Services
//{
//    public class BalanceSheetClient
//    {
//        private Storage.Sqlite.BalanceService BalanceService { get; set; }


//        public BalanceSheetClient()
//        {
//            //TODO: should DI this
//            BalanceService = new Storage.Sqlite.BalanceService();
//        }

//        public bool AddPost(Post post)
//        {
//            Storage.Sqlite.Models.Post SqlitePost = new Storage.Sqlite.Models.Post { Amount = post.Amount, Description = post.Description };
//            var result = BalanceService.AddPostToBalanceSheet(SqlitePost);

//            return result;
//        }

//        public bool DeletePost(Post post)
//        {
//            Storage.Sqlite.Models.Post SqlitePost = new Storage.Sqlite.Models.Post { Amount = post.Amount, Description = post.Description };
//            var result = BalanceService.RemovePostFromBalanceSheet(SqlitePost);

//            return result;
//        }

//        public IEnumerable<Post> GetPosts()
//        {
//            var result = BalanceService.GetPosts();
//            IEnumerable<Post> posts = new List<Post>();
//            foreach (var post in result)
//            {
//                var newPost = new Post { Amount = post.Amount, Description = post.Description };
//                posts.Append<Post>(newPost);
//            }
//            return posts;
//        }
//    }
//}
