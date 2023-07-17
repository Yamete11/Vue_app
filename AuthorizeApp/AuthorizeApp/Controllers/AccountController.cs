using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetLogin()
        {
            string answer = "Hello there";
            return Ok($"{answer}");
        }
    }
}
