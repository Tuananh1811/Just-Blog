using FA.JustBlog.Core.Models;

namespace FA.JustBlog.ViewModels.Posts
{
    public class GetAllPostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal? Rate { get; set; }
        public int ViewCount { get; set; }
        public string ShortDescription { get; set; }
        public string UrlSlug { get; set; }
        public Category Category { get; set; }
    }
}