using System;
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
            Console.WriteLine("--> Test Invocation is ok");
            return (Ok("Test invocation from command service"));
        }
    }
    
}