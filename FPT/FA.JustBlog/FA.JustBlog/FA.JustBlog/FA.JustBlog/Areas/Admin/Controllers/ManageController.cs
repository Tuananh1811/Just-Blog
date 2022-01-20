using FA.JustBlog.Core;
using FA.JustBlog.Services.Categories;
using FA.JustBlog.Services.Posts;
using System.Linq;
using System.Web.Mvc;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    public class ManageController : Controller
    {
        private readonly JustBlogContext context = new JustBlogContext();
        private readonly IPostService postService;
        private readonly ICategoryService categoryService;

        public ManageController(IPostService postService, ICategoryService categoryService)
        {
            this.postService = postService;
            this.categoryService = categoryService;
        }

        // GET: Admin/Manage
        public ActionResult Index()
        {
            var posts = context.Posts.ToList();
            var category = context.Categories.ToList();
            ViewBag.post = posts.Count;
            ViewBag.category = category.Count;
            return View();
        }
    }
}