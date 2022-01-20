using AutoMapper;
using FA.JustBlog.Core.Models;
using FA.JustBlog.ViewModels.Categories;
using FA.JustBlog.ViewModels.Posts;
using FA.JustBlog.ViewModels.Tags;

namespace FA.JustBlog.App_Start
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //post
            CreateMap<CreatePostViewModel, Post>().ReverseMap();

            CreateMap<UpdatePostViewModel, Post>().ReverseMap();

            CreateMap<Post, PostViewModel>().ReverseMap();

            CreateMap<Post, GetAllPostViewModel>().ReverseMap();

            CreateMap<Post, DetailsPostViewModel>().ReverseMap();



            CreateMap<Category, CategoryViewModel>().ReverseMap();

            CreateMap<Tag, TagViewModel>().ReverseMap();
        }
    }
}