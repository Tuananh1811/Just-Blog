using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.IRepositories;
using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FA.JustBlog.Core.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(JustBlogContext context):base(context)
        {
                
        }
        public int CountPostsForCategory(string category)
        {
            return this.dbSet.Where(x => x.Category.Name.Equals(category)).Count();
        }

        public Post FindPost(int year, int month, string urlSlug)
        {
            return this.dbSet.FirstOrDefault(x => x.CreatedOn.Year.Equals(year)
                    && x.CreatedOn.Month.Equals(month) && x.UrlSlug.Equals(urlSlug));
        }

        public IList<Post> GetHighestPosts(int size)
        {
            return this.dbSet.OrderByDescending(x => x.Rate).Take(size).ToList();
        }

        public IList<Post> GetLatestPost(int size)
        {
            return this.dbSet.OrderByDescending(x => x.CreatedOn).Take(size).ToList();
        }

        public IList<Post> GetMostViewedPost(int size)
        {
            return this.dbSet.OrderByDescending(x => x.ViewCount).Take(size).ToList();
        }

        public Post GetPostBySlugUrl(string slugUrl)
        {
            return this.dbSet.FirstOrDefault(x => x.UrlSlug.Equals(slugUrl));
        }

        public IList<Post> GetPostsByCategory(string category)
        {
            return this.dbSet.Where(x => x.Category.Name.Equals(category)).ToList();
        }

        public IList<Post> GetPostsByMonth(DateTime monthYear)
        {
            return this.dbSet.Where(x => x.CreatedOn.Month.Equals(monthYear)).ToList();
        }

        public IList<Post> GetPublisedPosts()
        {
            return this.dbSet.Where(x => x.Published.Equals(true)).ToList();
        }

        public IList<Post> GetUnpublisedPosts()
        {
            return this.dbSet.Where(x => x.Published.Equals(false)).ToList();
        }
    }
}
