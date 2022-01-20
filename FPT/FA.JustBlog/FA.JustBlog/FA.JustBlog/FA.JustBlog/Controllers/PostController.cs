using FA.JustBlog.Services.Posts;
using System.Web.Mvc;

namespace FA.JustBlog.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService;
        }

        // GET: Post
        public ActionResult GetPostByTitle(string url)
        {
            return View(this.postService.GetPostBySlugUrl(url));
        }
    }
}