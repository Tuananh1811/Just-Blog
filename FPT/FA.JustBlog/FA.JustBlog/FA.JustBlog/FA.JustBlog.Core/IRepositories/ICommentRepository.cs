using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Models;
using System.Collections.Generic;

namespace FA.JustBlog.Core.IRepositories
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        void AddComment(int postId, string commentName, string commentEmail, string commentTitle, string commentBody);
        IList<Comment> GetCommentsForPost(int postId);
        IList<Comment> GetCommentsForPost(Post post);

    }
}
