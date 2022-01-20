using FA.JustBlog.Core.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FA.JustBlog.ViewModels.Posts
{
    public class CreatePostViewModel
    {
        private decimal? rate;

        [Required(ErrorMessage = "Title cannot be empty")]
        [MaxLength(300, ErrorMessage = "Title requires at least 300 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Short Description cannot be empty")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "Post Content cannot be empty")]
        public string PostContent { get; set; }

        [Required(ErrorMessage = "Url Slug cannot be empty")]
        [MaxLength(300, ErrorMessage = "Url Slug requires at least 300 characters")]

        [DisplayName("Link Url")]
        public string UrlSlug { get; set; }

        [DisplayName("List Tag (;)")]
        public string Tags { get; set; }

        public bool Published { get; set; }

        [Required(ErrorMessage = "Category cannot be empty")]
        [DisplayName("Category")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "ViewCount cannot be empty")]
        public int ViewCount { get; set; }

        [Required(ErrorMessage = "RateCount cannot be empty")]
        public int RateCount { get; set; }

        [Required(ErrorMessage = "TotalRate cannot be empty")]
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
    }
}
