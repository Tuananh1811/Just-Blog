using FA.JustBlog.Core.Models;
using System;

namespace FA.JustBlog.ViewModels.Posts
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool Published { get; set; }
        public decimal? Rate { get; set; }
        public int ViewCount { get; set; }
        public string ShortDescription { get; set; }
        public string UrlSlug { get; set; }

    }
}
