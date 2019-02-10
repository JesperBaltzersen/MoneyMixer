using System;
using System.Collections.Generic;

namespace Persistance.Sqlite.Models
{
    public class BalanceSheet
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
