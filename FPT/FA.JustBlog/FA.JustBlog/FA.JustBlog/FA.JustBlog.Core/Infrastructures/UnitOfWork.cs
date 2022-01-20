using FA.JustBlog.Core.IRepositories;
using FA.JustBlog.Core.Repositories;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Infrastructures
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly JustBlogContext context;
        private ICategoryRepository categoryRepository;
        private ITagRepository tagRepository;
        private IPostRepository postRepository;
        private ICommentRepository commentRepository;

        public UnitOfWork(JustBlogContext context)
        {
            this.context = context;
        }

        public ICategoryRepository CategoryRepository {
            get
            {
                if(this.categoryRepository == null)
                {
                    this.categoryRepository = new CategoryRepository(this.context);
                }
                return this.categoryRepository;
            }
        }

        public IPostRepository PostRepository 
        {
            get
            {
                if (this.postRepository == null)
                {
                    this.postRepository = new PostRepository(this.context);
                }
                return this.postRepository;
            }
        }

        public ITagRepository TagRepository 
        {
            get
            {
                if (this.tagRepository == null)
                {
                    this.tagRepository = new TagRepository(this.context);
                }
                return this.tagRepository;
            }
        }

        public ICommentRepository CommentRepository
        {
            get
            {
                if (this.commentRepository == null)
                {
                    this.commentRepository = new CommentRepository(this.context);
                }
                return this.commentRepository;
            }
        }

        public JustBlogContext JustBlogContext => this.context;

        public void Dispose()
        {
            context.Dispose();
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await this.context.SaveChangesAsync();
        }
    }
}
