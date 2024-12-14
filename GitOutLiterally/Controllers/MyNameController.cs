using Microsoft.AspNetCore.Mvc;

namespace GitOutLiterally.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyNameController : ControllerBase
    {

        [HttpGet(Name = "GetMyName")]
        public string Get()
        {
            return "name:Madelyn_Lanier";
        }
    }
}
