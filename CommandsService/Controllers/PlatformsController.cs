using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase{

        public PlatformsController()
        {
            
        }

        [HttpPost]
        public ActionResult<string> TestInvocation() {
            return (Ok("Test invocation from command service"));
        }
    }
    
}