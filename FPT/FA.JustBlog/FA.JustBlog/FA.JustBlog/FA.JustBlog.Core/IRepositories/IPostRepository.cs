using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;

namespace FA.JustBlog.Core.IRepositories
{
    public interface IPostRepository : IGenericRepository<Post>
    {
        Post FindPost(int year, int month, string urlSlug);
        Post GetPostBySlugUrl(string slugUrl);
        IList<Post> GetPublisedPosts();
        IList<Post> GetUnpublisedPosts();
        IList<Post> GetLatestPost(int size);
        IList<Post> GetPostsByMonth(DateTime monthYear);
        int CountPostsForCategory(string category);
        IList<Post> GetPostsByCategory(string category);
        IList<Post> GetMostViewedPost(int size);
        IList<Post> GetHighestPosts(int size);


    }
}
