namespace CatShop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using CatShop.Models;
    using System.Linq;

    public class CatController : Controller
    {
        private readonly CatDbContext context;

        public CatController(CatDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            var cat = context.Cats.ToList();
            return View(cat);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(Cat cat)
        {
            context.Cats.Add(cat);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            var proj = context
                .Cats
                .Where(p => p.Id == id)
                .FirstOrDefault();

            return View(proj);
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Cat catModel)
        {
            context.Cats.Update(catModel);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            var proj = context
                .Cats
                .Where(p => p.Id == id)
                .FirstOrDefault();

            return View(proj);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Cat catModel)
        {
            var proj = context
                .Cats
                .Where(p => p.Id == id)
                .FirstOrDefault();
            context.Remove(proj);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
