using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.models
{
    [Table("POSTS")]
    public class Posts
    {
        [Key]
        public int id { get; set; } 
        [Required]
        public string title { get; set; } 
        public string body { get; set; }
        [ForeignKey("User")]
        public int userId { get; set; }
        [InverseProperty("posts")]
        public Users User { get; set; }

       // public Users User { get; set; }

    }
}
