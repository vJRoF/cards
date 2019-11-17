using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cards.MessageBroker;
using Cards.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cards.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SceneController : ControllerBase
    {
        [HttpPost]
        [Route("move")]
        public async Task<IActionResult> Move(CreateMoveRequest request)
        {
            using(var mb = new MessageBus("localhost:9092"))
            {
                await mb.SendMessage("test", Newtonsoft.Json.JsonConvert.SerializeObject(request));
            }

            return Ok();
        }
    }
}