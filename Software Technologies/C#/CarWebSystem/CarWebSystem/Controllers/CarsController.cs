using System.Linq;
using CarWebSystem.Data;
using CarWebSystem.Models;
using CarWebSystem.Models.Cars;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarWebSystem.Controllers
{
    public class CarsController : Controller

    {
        private CarSystemDbContext db;
        private UserManager<User> userManager;
        public CarsController(CarSystemDbContext db, UserManager<User> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }


        [HttpGet]
        [Authorize]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult Add(AddCarFormModel car)
        {
            if (ModelState.IsValid)
            {
                var userId = this.userManager.GetUserId(this.User);

                var carDb = (new Car
                {
                    ImageUrl = car.ImageUrl,
                    Make = car.Make,
                    Model = car.Model,
                    Price = car.Price,
                    Year = car.Year,
                    UserId = userId
                });

                this.db.Add(carDb);

                this.db.SaveChanges();

                return RedirectToAction(nameof(Details), new { carDb.Id });
            }
            return View(); 
        }

        public IActionResult All()
        {
            var cars = this.db.Cars
                .OrderByDescending(c => c.Id)
                .Select(c => new CarListingViewModel
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    ImageUrl = c.ImageUrl

                })
                .ToList();
            return View(cars);
        }

        public IActionResult Details(int id)
        {
            var car = this.db
                .Cars
                .Where(c => c.Id == id)
                .Select(c => new CarDetailsViewModel
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    Price = c.Price,
                    Year = c.Year,
                    ImageUrl = c.ImageUrl,
                    UserId = c.UserId,
                    Username = c.User.UserName
                })
                .FirstOrDefault();

            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        [Authorize]
        public IActionResult Delete(int id)
        {

            var userId = this.userManager.GetUserId(this.User);
            var car = this.db.Cars
                .Where(c => c.Id == id && c.UserId == userId)
                .Select(c => new DeleteCarViewModel
                    {
                        Id = c.Id,
                        Car = $"{c.Make} {c.Model}"
                    })
                .FirstOrDefault();

            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }
        [Authorize]
        public IActionResult ConfirmDelete(int id)
        {
            var userId = this.userManager.GetUserId(this.User);
            var car = this.db.Cars
                .Where(c => c.Id == id && c.UserId == userId)
                .FirstOrDefault();

            if (car == null)
            {
                return NotFound();
            }

            this.db.Cars.Remove(car);
            this.db.SaveChanges();

            return RedirectToAction(nameof(All));
        }
    }
}
