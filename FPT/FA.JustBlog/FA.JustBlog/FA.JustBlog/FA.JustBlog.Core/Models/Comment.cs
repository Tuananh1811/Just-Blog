using FA.JustBlog.Core.BaseEntities;
using System;
using System.ComponentModel.DataAnnotations;

namespace FA.JustBlog.Core.Models
{
    public class Comment : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Name { get; set; }

        [Required]
        [MaxLength(300)]
        public string Email { get; set; }

        public int PostId { get; set; }

        [Required]
        [MaxLength(300)]
        public string CommentHeader { get; set; }

        [Required]
        public string CommentText { get; set; }

        public virtual Post Post { get; set; }
    }
}
