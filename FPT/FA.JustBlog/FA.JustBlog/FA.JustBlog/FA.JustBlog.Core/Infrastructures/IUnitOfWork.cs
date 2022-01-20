using FA.JustBlog.Core.IRepositories;
using System;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Infrastructures
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; }
        IPostRepository PostRepository { get; }
        ITagRepository TagRepository { get; }
        ICommentRepository CommentRepository { get; }

        JustBlogContext JustBlogContext { get; }

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}
