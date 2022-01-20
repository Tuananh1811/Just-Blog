using FA.JustBlog.Core.BaseEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FA.JustBlog.Core.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string UrlSlug { get; set; }
        public string Description { get; set; }
        public int? Count { get; set; }

        public virtual ICollection<PostTag> PostTags { get; set; }

        //public virtual ICollection<Post> Posts { get; set; }


    }
}
