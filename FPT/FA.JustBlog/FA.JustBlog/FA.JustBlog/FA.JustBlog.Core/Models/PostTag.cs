using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FA.JustBlog.Core.Models
{
    public class PostTag
    {
        [Key]
        [Column(Order = 0)]
        public int PostId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int TagId { get; set; }

        [ForeignKey(nameof(PostId))]
        public virtual Post Posts { get; set; }

        [ForeignKey(nameof(TagId))]
        public virtual Tag Tags { get; set; }
    }
}
