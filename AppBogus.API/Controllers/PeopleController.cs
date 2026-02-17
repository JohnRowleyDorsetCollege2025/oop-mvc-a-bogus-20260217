using AppBogus.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppBogus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {


        private FakeDataService _fs;
        public PeopleController(FakeDataService fs)
        {
            _fs = fs;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var people = _fs.GetPeople();
            return Ok(people);
        }
    }
}
