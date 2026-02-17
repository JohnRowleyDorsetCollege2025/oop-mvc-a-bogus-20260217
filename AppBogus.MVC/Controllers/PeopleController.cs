using AppBogus.Domain;
using AppBogus.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppBogus.MVC.Controllers
{
    public class PeopleController : Controller
    {
        private FakeDataService _fs;
        public PeopleController(FakeDataService fs)
        {
             _fs = fs;
        }
        public IActionResult Index()
        {


            return View(_fs.GetPeople());
        }
    }
}
