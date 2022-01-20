using FA.JustBlog.ViewModels.Tags;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace FA.JustBlog.ViewModels.Posts
{
    public class DetailsPostViewModel
    {
        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string PostContent { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        [DisplayName("Link Url")]
        public string UrlSlug { get; set; }

        public bool Published { get; set; }

        public int ViewCount { get; set; }

        public decimal? Rate { get; set; }

        public List<TagViewModel> Tags { get; set; } = new List<TagViewModel>();
    }
}
