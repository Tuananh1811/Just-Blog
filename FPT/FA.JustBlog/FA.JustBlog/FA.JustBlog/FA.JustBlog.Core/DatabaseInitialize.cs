using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FA.JustBlog.Core
{
    public class DatabaseInitialize : CreateDatabaseIfNotExists<JustBlogContext>
    {
        public void SeedData(JustBlogContext context)
        {
            base.Seed(context);

            if (context.Tags.Any() && context.Posts.Any() && context.Categories.Any())
                return;

            var category = new Category()
            {
                Name = "thể thao",
                UrlSlug = "the-thao",
                Description = "Tin tức về thể thao",
                Posts = new List<Post>()
                {
                    new Post()
                    {
                        Title = "Kết quả bóng đá Tottenham - Vitesse: Conte ra mắt, rượt đuổi 5 bàn & 3 thẻ đỏ",
                        ShortDescription = "Description1",
                        PostContent = "Content1",
                        UrlSlug = "tin-tuc",
                        Published = true,
                        ViewCount = 10032,
                        RateCount = 102,
                        TotalRate = 403,
                    },
                    new Post()
                    {
                        Title = "Kết quả bóng đá Leicester City - Spartak Moscow: Vardy trượt 11m, dấu ấn Victor Moses (Europa League)",
                        ShortDescription = "Description2",
                        PostContent = "Content2",
                        UrlSlug = "the-thao",
                        Published = true,
                        ViewCount = 10054,
                        RateCount = 205,
                        TotalRate = 503,
                    },
                    new Post()
                    {
                        Title = "Son Heung Min lập kỳ tích, HLV Conte nói gì sau chiến thắng ngày ra mắt?",
                        ShortDescription = "Description3",
                        PostContent = "Content3",
                        UrlSlug = "the-thao",
                        Published = true,
                        ViewCount = 1500,
                        RateCount = 100,
                        TotalRate = 80,
                    },
                }
            };

            var tag = new Tag()
            {
                Name = "tag 1",
                UrlSlug = "ngoai-hang-anh",
                Description = "Tin tức bóng đá",
                Count = 1,
            };

            context.Categories.Add(category);

            context.Tags.Add(tag);

            context.SaveChanges();
        }
    }
}
