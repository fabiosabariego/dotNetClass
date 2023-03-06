using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() { Name = "Sif", Age = 3 };
            return View(doggo);
        }

        public IActionResult Hello()
        {
            DogViewModel doggy = new DogViewModel() { Name = "Lia", Age = 10 };
            return View(doggy);
        }

        public IActionResult Create()
        {
            var dogMV = new DogViewModel();
            return View(dogMV);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            return View("Index");
        }
    }
}
