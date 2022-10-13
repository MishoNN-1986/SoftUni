using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EfCodeF.Infrastructure.Data
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public HashSet<Post> Posts { get; set; } = new HashSet<Post>();

        public HashSet<Comment> Comments { get; set; } = new HashSet<Comment>();

        public HashSet<Reply> Replies { get; set; } = new HashSet<Reply>();
    }
}
