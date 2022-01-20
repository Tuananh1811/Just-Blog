using AutoMapper;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Models;
using FA.JustBlog.ViewModels.Categories;
using FA.JustBlog.ViewModels.Results;
using System;
using System.Collections.Generic;

namespace FA.JustBlog.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<CategoryViewModel> GetAll()
        {
            var posts = this.unitOfWork.CategoryRepository.GetAll();
            return Mapper.Map<IEnumerable<CategoryViewModel>>(posts);
        }

        public ResponseResult Create(CategoryViewModel request)
        {
            try
            {
                var category = Mapper.Map<Category>(request);
                this.unitOfWork.CategoryRepository.Add(category);
                this.unitOfWork.SaveChanges();
                return new ResponseResult();
            }
            catch (Exception ex)
            {
                return new ResponseResult(ex.Message);
            }
        }

        public ResponseResult Delete(int? id)
        {
            try
            {
                this.unitOfWork.CategoryRepository.Delete(id);
                this.unitOfWork.SaveChanges();
                return new ResponseResult();
            }
            catch (Exception ex)
            {
                return new ResponseResult(ex.Message);
            }
        }

        public Category Find(int? id)
        {
            return unitOfWork.CategoryRepository.Find(id);
        }

        public ResponseResult Update(CategoryViewModel request)
        {
            try
            {
                var category = this.unitOfWork.CategoryRepository.Find(request.Id);
                category.Name = request.Name;
                category.UrlSlug = request.UrlSlug;
                category.Description = request.Description;
                this.unitOfWork.CategoryRepository.Update(category);
                this.unitOfWork.SaveChanges();
                return new ResponseResult();
            }
            catch (Exception ex)
            {
                return new ResponseResult(ex.Message);
            }
        }
        public CategoryViewModel GetDetails(int? id)
        {
            var categories = this.unitOfWork.CategoryRepository.Find(id);
            return Mapper.Map<CategoryViewModel>(categories);
        }
        public CategoryViewModel GetCategoryUpdate(int? id)
        {
            var category = this.unitOfWork.CategoryRepository.Find(id);
            return Mapper.Map<CategoryViewModel>(category);
        }
    }
}