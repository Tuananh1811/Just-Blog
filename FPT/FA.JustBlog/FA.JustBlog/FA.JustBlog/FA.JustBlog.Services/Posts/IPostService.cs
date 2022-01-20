using FA.JustBlog.Core.Models;
using FA.JustBlog.ViewModels.Posts;
using FA.JustBlog.ViewModels.Results;
using System.Collections.Generic;

namespace FA.JustBlog.Services.Posts
{
    public interface IPostService
    {
        ResponseResult Create(CreatePostViewModel request);

        ResponseResult Update(UpdatePostViewModel request);
        ResponseResult Delete(int? id);

        Post Find(int? id);

        DetailsPostViewModel GetPostBySlugUrl(string slugUrl);

        IEnumerable<PostViewModel> GetAll();

        IEnumerable<GetAllPostViewModel> GetIndex();
        DetailsPostViewModel GetDetails(int? id);

        UpdatePostViewModel GetPostUpdate(int? id);

    }
}