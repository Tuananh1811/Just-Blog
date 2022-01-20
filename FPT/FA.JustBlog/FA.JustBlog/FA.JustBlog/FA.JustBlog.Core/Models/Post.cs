using FA.JustBlog.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FA.JustBlog.Core.Models
{
    public class Post : BaseEntity
    {
        private decimal? rate;

        public Post()
        {
            Comments = new List<Comment>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string PostContent { get; set; }

        [Required]
        [MaxLength(300)]
        public string UrlSlug { get; set; }

        public bool Published { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int ViewCount { get; set; }
        [Required]
        public int RateCount { get; set; }
        [Required]
        public int TotalRate { get; set; }

        public decimal? Rate 
        {
            get => this.rate;
            set
            {
                if (this.RateCount > 0 && this.TotalRate > 0)
                    this.rate = Math.Round((decimal)this.TotalRate / this.RateCount, 1);
                else
                    this.rate = null;
            }
        }   
        
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public virtual ICollection<PostTag> PostTags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }


    }
}
