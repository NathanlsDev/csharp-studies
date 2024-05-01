using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("GetDateAndTime")]
        public IActionResult GetDateTime()
        {
            var obj = new
            {
                Date = DateTime.Now.ToLongDateString(),
                Hour = DateTime.Now.ToShortTimeString(),
            };

            return Ok(obj);
        }

    [HttpGet("Salutation/{name}")]
        public IActionResult Salutation(string name)
        {
            var message = $"Hello {name}, you're welcome!";
            return Ok(new { message });
        }
    }
}