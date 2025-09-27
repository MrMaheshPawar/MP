using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string get()
        {
            return "Hello MP , Your Web Api Is Working well!!";
        }
    }
}
