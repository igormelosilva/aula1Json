using Microsoft.AspNetCore.Mvc;

namespace aula1Json.Controllers
{
    [ApiController]
    [Route("api/Home")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("HandShake")]
        public string HandShake()
        {
            return "ok";
        }

    }
}
