using DevanshAddNumbers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Diagnostics;

namespace DevanshAddNumbers.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AddNumbers obj)
        {
            if (ModelState.IsValid)
            {
                // Do the sum and result to view
                // Viewbag ::
                ViewBag.Sum = obj.Sum();
                return View();
            }
            else {
                ViewBag.Sum = "";
            }
            return View(obj);
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
