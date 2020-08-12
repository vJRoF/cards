using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cards.Front.Hubs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Cards.Front.Controllers
{
    [ApiController]
    public class DesktopController : ControllerBase
    {
        private readonly IHubContext<CardsHub> _cardsHubContext;

        public DesktopController(IHubContext<CardsHub> cardsHubContext)
        {
            _cardsHubContext = cardsHubContext ?? throw new ArgumentNullException(nameof(cardsHubContext));
        }

        /// <summary>
        ///     Положить выбранную карту на стол
        /// </summary>
        [HttpPost("api/v1/desctop/add-card")]
        public async Task<IActionResult> Card()
        {
            await _cardsHubContext.Clients.All.SendAsync("messageRecieved", 0, "hello");
            return NoContent();
        }
    }
}