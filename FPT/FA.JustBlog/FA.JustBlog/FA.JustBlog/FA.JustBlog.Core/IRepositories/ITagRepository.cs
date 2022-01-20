using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.IRepositories
{
    public interface ITagRepository : IGenericRepository<Tag>
    {
        IEnumerable<int> AddTagByString(string tags);
        Tag GetTagByUrlSlug(string urlSlug);
    }
}
