using FisrtMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FisrtMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
          return View(dogs);
        }
        public IActionResult Create()
        {
            var dogVm = new DogViewModel(); 
            return View(dogVm);
        } 
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }


        public string Hello()
        {
            return "whos there?";
        }
    }
}
