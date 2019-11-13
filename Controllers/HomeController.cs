using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using chefsndishes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace chefsndishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            List<Chef> AllChefs = dbContext.Chefs
                .Include(chef => chef.CreatedDishes)
                .ToList();
            return View(AllChefs);
        }

        [HttpGet("/new")]
        public IActionResult AddChefPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddChef(Chef newChef)
        {
            DateTime today = DateTime.Now;
            int calcage = today.Year - newChef.DOB.Year;
            newChef.Age = calcage;
            if (calcage < 18)
            {
                ModelState.AddModelError("DOB", "The chef must be at least 18 years old");
                return View("AddChefPage");
            }
            dbContext.Add(newChef);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("/dishes")]
        public IActionResult DishesPage()
        {
            List<Dish> AllDishes = dbContext.Dishes
                .Include(dish => dish.Creator)
                .ToList();
            return View(AllDishes);
        }

        [HttpGet("/dishes/new")]
        public IActionResult AddDishPage()
        {
            DisplayDishesViewModel ChefList = new DisplayDishesViewModel()
            {
                Chefs = dbContext.Chefs.ToList()
            };
            return View(ChefList);
        }

        [HttpPost]
        public IActionResult AddDish(DisplayDishesViewModel viewmodelDish)

        {
            
            Dish dish = viewmodelDish.Dishes;
            DisplayDishesViewModel ChefList = new DisplayDishesViewModel()
            {
                Chefs = dbContext.Chefs.ToList()
            };
            Console.WriteLine($"###############################{dish.Description}#################################################");
            dbContext.Add(dish);
            Console.WriteLine($"###############################{dish}#################################################");
            dbContext.SaveChanges();
            Console.WriteLine($"###############################{dish}#################################################");
            return RedirectToAction("DishesPage");

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}