using AutoMapper;
using FA.JustBlog.Core;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Services.Categories;
using FA.JustBlog.Services.Posts;
using FA.JustBlog.ViewModels.Posts;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    public class ManagePostController : Controller
    {
        private readonly JustBlogContext context = new JustBlogContext();
        private readonly IPostService postService;
        private readonly ICategoryService categoryService;

        public ManagePostController(IPostService postService, ICategoryService categoryService)
        {
            this.postService = postService;
            this.categoryService = categoryService;
        }

        // GET: Admin/Posts
        public ActionResult Index()
        {
            var posts = postService.GetIndex();
            return View(posts);
        }

        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var post = this.postService.GetDetails(id);
            if(post == null)
            {
                TempData["Message"] = "Not found";
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(context.Categories, "Id", "Name");
            //var categories = this.categoryService.GetAll();
            //ViewBag.CategoryId = new SelectList(categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(CreatePostViewModel request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            var response = this.postService.Create(request);
            if (response.IsSucceed)
            {
                TempData["Message"] = "Created Successfuly!"; 
                return RedirectToAction(nameof(Index));
            }
            ModelState.AddModelError(string.Empty, response.ErrorMessage);
            return View(request);
        }

        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var post = this.postService.GetPostUpdate(id);
            if (post == null)
            {
                TempData["Message"] = "Not found";
                return RedirectToAction(nameof(Index));
            }
            //TempData["Category"] = this.categoryService.GetAll();
            ViewBag.CategoryId = new SelectList(context.Categories, "Id", "Name");
            return View(post);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Update(UpdatePostViewModel request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            var response = this.postService.Update(request);
            if (response.IsSucceed)
            {
                TempData["Message"] = "Updated Successfuly!";
                return RedirectToAction(nameof(Index));
            }
            ModelState.AddModelError(string.Empty, response.ErrorMessage);
            return View(request);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var post = this.postService.GetDetails(id);
            if (post == null)
            {
                TempData["Message"] = "Not found";
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            var response = this.postService.Delete(id);
            if (response.IsSucceed)
            {
                TempData["Message"] = "Deleted Successfuly!";
                return RedirectToAction(nameof(Index));
            }
            ModelState.AddModelError(string.Empty, response.ErrorMessage);
            return View();
        }

    }
}