using D_D_Class_Selector.Models;
using Microsoft.AspNetCore.Mvc;

namespace D_D_Class_Selector.Controllers
{
    public class ClassesController : Controller
    {
        private readonly IClassesRepository repo;

        public ClassesController(IClassesRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var classes = repo.GetAllClasses();
            return View(classes);
        }
        public IActionResult ViewClass(int id)
        {
            var classes = repo.GetClasses(id);
            return View(classes);
        }
    }
}
