using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Persistance.Sqlite.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        [Required(ErrorMessage = "Input a number")]
        [DataType(DataType.Currency, ErrorMessage = "Input a number")]
        public double Amount { get; set; }
        public string Description { get; set; }
        public string ImgLocation { get; set; }
        public string LinkedFiles { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public User Owner { get; set; }
    }
}
