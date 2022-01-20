using FA.JustBlog.Core.Models;
using FA.JustBlog.ViewModels.Categories;
using FA.JustBlog.ViewModels.Results;
using System.Collections.Generic;

namespace FA.JustBlog.Services.Categories
{
    public interface ICategoryService
    {
        IEnumerable<CategoryViewModel> GetAll();

        ResponseResult Create(CategoryViewModel request);

        ResponseResult Update(CategoryViewModel request);

        ResponseResult Delete(int? id);

        Category Find(int? id);
        CategoryViewModel GetDetails(int? id);
        CategoryViewModel GetCategoryUpdate(int? id);
    }
}