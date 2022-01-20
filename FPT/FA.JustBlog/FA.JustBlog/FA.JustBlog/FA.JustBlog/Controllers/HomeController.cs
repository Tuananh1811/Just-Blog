using FA.JustBlog.Services.Posts;
using PagedList;
using System.Web.Mvc;

namespace FA.JustBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService postService;

        public HomeController(IPostService postService)
        {
            this.postService = postService;
        }

        public ActionResult Index(int? page)
        {
            if (page == null) page = 1;
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(this.postService.GetAll().ToPagedList(pageNumber, pageSize));
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

    }
}