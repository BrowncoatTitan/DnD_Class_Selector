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
            var classes = repo.GetClass(id);
            return View(classes);
        }
        public IActionResult UpdateClass(int id)
        {
             Classes classes = repo.GetClass(id);
            if (classes == null)
            {
                return View("ClassNotFound");
            }
            return View(classes);
        }
        public IActionResult UpdateClassToDatabase(Classes classes)
        {
            repo.UpdateClass(classes);

            return RedirectToAction("ViewProduct", new { id = classes.ID });
        }
        public IActionResult InsertClass() 
        {
            var classes = new Classes();
            return View(classes); 
        }
        public IActionResult InsertClassToDatabase(Classes classToInsert)
        {
            repo.InsertClass(classToInsert);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteClass(Classes classes)
        {
            repo.DeleteClass(classes);
            return RedirectToAction("Index");
        }
    }
}
