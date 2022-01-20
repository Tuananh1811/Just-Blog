using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.IRepositories;
using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FA.JustBlog.Core.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(JustBlogContext context):base(context)
        {

        }
        public void AddComment(int postId, string commentName, string commentEmail, string commentTitle, string commentBody)
        {
            Comment comment = new Comment();
            comment.PostId = postId;
            comment.Name = commentName;
            comment.Email = commentEmail;
            comment.CommentHeader = commentTitle;
            comment.CommentText = commentBody;
            this.dbSet.Add(comment);
        }

        public IList<Comment> GetCommentsForPost(int postId)
        {
            return this.dbSet.Where(x => x.Post.Id.Equals(postId)).ToList();
        }

        public IList<Comment> GetCommentsForPost(Post post)
        {
            return this.dbSet.Where(x => x.Post.Equals(post)).ToList();
        }
    }
}
