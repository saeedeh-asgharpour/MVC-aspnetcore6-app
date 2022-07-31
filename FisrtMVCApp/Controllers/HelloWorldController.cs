using FisrtMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FisrtMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel()
            { Name = "sif", Age = 2};
            return View(doggo);
                
        }
        public IActionResult Create()
        { 
            return View();
        }


        public string Hello()
        {
            return "whos there?";
        }
    }
}
