using Cards.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Cards.Front.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Cards.Front.Controllers
{
    [Authorize]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly HttpClient _httpClient;

        public CardsController(
            AppDbContext appDbContext,
            IHttpClientFactory httpClientFactory)
        {
            _appDbContext = appDbContext ?? throw new ArgumentNullException(nameof(appDbContext));
            _httpClient = httpClientFactory.CreateClient("google");
        }

        [HttpGet("api/v1/cards/deck-list")]
        public Task<DeckModel[]> Decks()
        {
            return _appDbContext.Cards
                .Select(c => c.DeckName)
                .Distinct()
                .Select(deckName => new DeckModel {Name = deckName})
                .ToArrayAsync();
        }

        [HttpGet("api/v1/cards/picture/{cardId}")]
        public async Task<IActionResult> Picture(int cardId)
        {
            var card = await _appDbContext.Cards.FindAsync(1);

            var image = await _httpClient.GetByteArrayAsync(card.PictureUri);

            return File(image, "image/png");
        }
    }
}