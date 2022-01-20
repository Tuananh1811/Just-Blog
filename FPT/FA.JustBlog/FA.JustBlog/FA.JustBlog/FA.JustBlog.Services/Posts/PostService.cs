using AutoMapper;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Models;
using FA.JustBlog.ViewModels.Posts;
using FA.JustBlog.ViewModels.Results;
using FA.JustBlog.ViewModels.Tags;
using System;
using System.Collections.Generic;

namespace FA.JustBlog.Services.Posts
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork unitOfWork;

        public PostService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public ResponseResult Create(CreatePostViewModel request)
        {
            try
            {
                //1. Add tag to database
                var tagIds = this.unitOfWork.TagRepository.AddTagByString(request.Tags);
                //2. Create postTag
                var postTags = new List<PostTag>(); 
                foreach (var tagId in tagIds)
                {
                    var postTag = new PostTag()
                    {
                        TagId = tagId
                    };
                    postTags.Add(postTag);
                }

                var post = Mapper.Map<Post>(request);
                post.PostTags = postTags;
                this.unitOfWork.PostRepository.Add(post);
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
                this.unitOfWork.PostRepository.Delete(id);
                this.unitOfWork.SaveChanges();
                return new ResponseResult();
            }
            catch (Exception ex)
            {
                return new ResponseResult(ex.Message);
            }
            
        }

        public Post Find(int? id)
        {
            return this.unitOfWork.PostRepository.Find(id);
        }

        public IEnumerable<PostViewModel> GetAll()
        {
            var posts = this.unitOfWork.PostRepository.GetAll();
            return Mapper.Map<IEnumerable<PostViewModel>>(posts);
        }

        public DetailsPostViewModel GetDetails(int? id)
        {
            var posts = this.unitOfWork.PostRepository.Find(id);
            return Mapper.Map<DetailsPostViewModel>(posts);
        }

        public IEnumerable<GetAllPostViewModel> GetIndex()
        {
            var posts = this.unitOfWork.PostRepository.GetAll();
            return Mapper.Map<IEnumerable<GetAllPostViewModel>>(posts);
        }

        public DetailsPostViewModel GetPostBySlugUrl(string slugUrl)
        {
            var postExisting =  this.unitOfWork.PostRepository.GetPostBySlugUrl(slugUrl);
            var tags = new List<TagViewModel>();
            foreach (var postTag in postExisting.PostTags)
            {
                var tag = this.unitOfWork.TagRepository.Find(postTag.TagId);
                tags.Add(Mapper.Map<TagViewModel>(tag));
            }
            var postDetail = Mapper.Map<DetailsPostViewModel>(postExisting);
            postDetail.Tags = tags;
            return postDetail;
        }

        public UpdatePostViewModel GetPostUpdate(int? id)
        {
            var post = this.unitOfWork.PostRepository.Find(id);
            return Mapper.Map<UpdatePostViewModel>(post);
        }

        public ResponseResult Update(UpdatePostViewModel request)
        {
            try
            {
                var post = this.unitOfWork.PostRepository.Find(request.Id);
                post.Title = request.Title;
                post.ShortDescription = request.ShortDescription;
                post.PostContent = request.PostContent;
                post.UrlSlug = request.UrlSlug;
                post.Published = request.Published;
                post.CategoryId = request.CategoryId;
                post.ViewCount = request.ViewCount;
                post.RateCount = request.RateCount;
                post.TotalRate = request.TotalRate;
                post.Rate = request.Rate;
                this.unitOfWork.PostRepository.Update(post);
                this.unitOfWork.SaveChanges();
                return new ResponseResult();
            }
            catch (Exception ex)
            {
                return new ResponseResult(ex.Message);
            }
        }
    }
}
