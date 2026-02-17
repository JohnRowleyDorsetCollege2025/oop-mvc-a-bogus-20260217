using AppBogus.Domain;
using AppBogus.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppBogus.MVC.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            FakeDataService fs = new FakeDataService(); 

            return View(fs.GetPeople());
        }
    }
}
