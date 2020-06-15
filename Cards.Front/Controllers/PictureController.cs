using Cards.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Cards.Front.Controllers
{
    [ApiController]
    public class PictureController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        #region image bas64
        private const string _imageBase64 = "iVBORw0KGgoAAAANSUhEUgAAAKUAAADkCAIAAAB2TXNEAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAVCSURBVHhe7dtrdqJKFEDhjIsBOR5H42QcTJpCcgXqARqzLqf23r+6k+jK8vNUIZCvbyOlNyu9WenNSm9WerPSm5XerPRmpTcrvVnpzUpvVnqz0puV3qz0ZqU3K71Z6c1Kb1Z6s9Kbld6s9GalNyu9WenNSm9WerPSm5XerPRmpTcrvVnpzUpvVnqz0puV3qz0ZqU3K71Z6c1Kb1Z6s9Kbld6s9GalNyu9WenNSm9WerPSm5XerPRmpTcrvVnpzUpvVnqz0puV3qz0ZqU3K71Z6c1Kb1Z6s9Kbld6s9GalNyu9WenNCul9/2n+Pyii9+0yPLrywIHet8vXHBAc532/DrP2GA+c5r3iBoLDvDfcPHCWd8aNA0d5F7hp4CTvIjcMHORd4WaBc7yr3ChwjHeDe+xym3+s9yjebW4OOMR7jxsDzvDe56aAI7zX3Jfb84rJMgQ4wXvLvbhCtooADvBe6ybUijcBvH/vnLvqDQDv3rvAXffuH7x37xJ3w7t78M69i9wt797B+/Yucze9Owfv2nvlurgo0vTu++pJz9417h3vrsFP5X2/XT7Z8izLynDH+2sY5mf4SNfbid4+J5vvUXz/TPcbrUd2z/uDnW2tOOF6/hfm64Owhvfbkz3kv/MZ94WT7t8fNz+0nr8BdL/frlGsUyc+XssuYg6X67X44h7rOeNl75eIKsxTw+VMO/a6E3unCubptXxM1fyl4/2Il7yPabeYp85snTq591i+tC9e01fhH+K59472LvPU2a1T5/dONc2nDsMn8a33+mju2THmR2fdsDfF8E7dM8/iPO3DDxvDTPsV5qkg1qk43qn8PrShejbjoNpT+2XmqQiL+KJY3qmSefMVbzmOWO8xTwWzTsXzHit8Oj+ypP5CNi+gdSqkd+pd8/Fxv0cPtGFvCuudypf2mkTlKC6dPX3VPq51KrR3qrCdX/4TGZVLzIseh2tHV/r60WGUwnunCuZj8z/3Ws1rAz7ohr2pC++xwnZeaZzozfmWfIXevoH6sE714l0a8lLT+p2fT92ec9k82fbbcevG+wj3zyCXrpdsSHsF72Y93+d+Ltsl7+2y3il4J9773EuwsvdGvE/wPrx3uddaNe+xxQ92Cd6F9x73lqrhvfzhHsF78G5z55+22t6LR3QI3oF3k7ugPX5Un79Z7edR/YHH925xb4Hut+ZSsOzx0PWTF9480Qrv3eBeax8/Azc3Pbw38Ojede6F9gtjvSrxdgYe3LvG/XQpXSefzoYfmvfxefoCj+1d4Z5RSmO9vqJ5ZPAv157AQ3uXuSeR6ljnvbixxwaP7F3kHlELt7Ls3ajwyg4fGjywd4l7yG9OW9zustPRQY8MHte7snevev0+hUODHhg8rPce9/Gxztsd9LjgUb2b3J+4/ag96GHBg3pXuX8z1nn1QY8KHtS7eMnjb+4qrAx6UPCY3hn3Z8c6r/RxPiR4SO8199+Mdd72c31I8IjeT+6/Huu85aBHBA/oPY7Z1P/2tz1p0OffYP5KnIIer9mb6c1Kb1Z6s9Kbld6s9GalNyu9WenNSm9WerPSm5XerPRmpTcrvVnpzUpvVnqz0puV3qz0ZqU3K71Z6c1Kb1Z6s9Kbld6s9GalNyu9WenNSm9WerPSm5XerPRmpTcrvVnpzUpvVnqz0puV3qz0ZqU3K71Z6c1Kb1Z6s9Kbld6s9GalNyu9WenNSm9WerPSm5XerPRmpTcrvVnpzUpvVnqz0puV3qz0ZqU3K71Z6c1Kb1Z6s9Kbld6s9GalNyu9WenNSm9WerPSm9T39z9PkIAPmymMmAAAAABJRU5ErkJggg==";
        #endregion

        public PictureController(
            AppDbContext appDbContext)
        {
            _appDbContext = appDbContext ?? throw new ArgumentNullException(nameof(appDbContext));
        }

        [HttpGet("api/v1/picture/{deckId}/{cardId}")]
        public IActionResult Picture(int cardId)
        {
            var card = _appDbContext.Cards.Find(1);
            return File(Convert.FromBase64String(_imageBase64), "image/png");
        }
    }
}