using FA.JustBlog.Core;
using FA.JustBlog.Services.Categories;
using FA.JustBlog.ViewModels.Categories;
using System.Net;
using System.Web.Mvc;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    public class ManageCategoryController : Controller
    {
        // GET: Admin/ManageCategory
        private readonly JustBlogContext context = new JustBlogContext();
        private readonly ICategoryService categoryService;

        public ManageCategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        // GET: Admin/Posts
        public ActionResult Index()
        {
            var category = categoryService.GetAll();
            return View(category);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var category = this.categoryService.GetDetails(id);
            if (category == null)
            {
                TempData["Message"] = "Not found";
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(CategoryViewModel request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            var response = this.categoryService.Create(request);
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
            var category = this.categoryService.GetCategoryUpdate(id);
            if (category == null)
            {
                TempData["Message"] = "Not found";
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Update(CategoryViewModel request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            var response = this.categoryService.Update(request);
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
            var category = this.categoryService.GetDetails(id);
            if (category == null)
            {
                TempData["Message"] = "Not found";
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            var response = this.categoryService.Delete(id);
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