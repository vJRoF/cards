using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cards.Front.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesktopController : ControllerBase
    {
        /// <summary>
        ///     Положить выбранную карту на стол
        /// </summary>
        [HttpPost("card")]
        public IActionResult Card()
        {
            return NoContent();
        }
    }
}