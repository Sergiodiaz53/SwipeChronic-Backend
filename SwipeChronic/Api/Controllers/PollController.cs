using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace SwipeChronic.Controllers
{
    [Route("api/[controller]")]
    public class PollController : Controller
    {
        //GET: api/PollController/question
        [HttpPost("question")]
        public Task<IActionResult> SetQuestion ([FromBody])
    }
}
