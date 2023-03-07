using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index()
        {
            //DogViewModel doggo = new DogViewModel() { Name = "Sif", Age = 3 };
            return View(dogs);
        }

        public IActionResult Hello()
        {
            DogViewModel doggy = new DogViewModel() { Name = "Lia", Age = 10 };
            return View(doggy);
        }

        public IActionResult Create()
        {
            //var dogMV = new DogViewModel();
            //dogMV.Name = "Thor";
            //dogMV.Age = 12;
            //return View(dogMV);
            return View();
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
