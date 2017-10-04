using _14DTHC1_2.Models;
using _14DTHC1_2.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace _14DTHC1_2.Controllers
{
    [Authorize]
    public class CoursesController : Controller
    {
        private ApplicationDbContext dbContext;

        public CoursesController()
        {
            dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var courseViewModel = new CourseViewModel()
            {
                Categories = dbContext.Categories.ToList()
            };
            return View(courseViewModel);
        }
    }
}