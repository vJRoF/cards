using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Cards.DataAccess;
using Cards.Front.Model;
using Cards.Front.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.Swagger.Annotations;

namespace Cards.Front.Controllers
{
    [ApiController]
    public class AccountController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly AuthOptions _authOptions;

        public AccountController(
            IOptions<AuthOptions> authOptionsAccessor,
            AppDbContext appDbContext)
        {
            _appDbContext = appDbContext ?? throw new ArgumentNullException(nameof(appDbContext));
            _authOptions = authOptionsAccessor.Value ?? throw new ArgumentNullException(nameof(_authOptions));
        }

        [HttpPost("/token")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(TokenCreatedModel))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        public IActionResult Token(
            [Required] string username,
            [Required] string password)
        {
            var identity = GetIdentity(username, password);
            if (identity == null)
            {
                return BadRequest(new { errorText = "Invalid username or password." });
            }

            var now = DateTime.UtcNow;
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                issuer: _authOptions.Issuer,
                audience: _authOptions.Audience,
                notBefore: now,
                claims: identity.Claims,
                expires: now.Add(_authOptions.TokenLifetime),
                signingCredentials: new SigningCredentials(_authOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            
            return Ok(new TokenCreatedModel{Token = encodedJwt, UserName = identity.Name});
        }

        private ClaimsIdentity GetIdentity(string username, string password)
        {
            var user = _appDbContext.Users.FirstOrDefault(x => x.Name == username);
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Name)
                };
                ClaimsIdentity claimsIdentity =
                    new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                        ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }

            // если пользователя не найдено
            return null;
        }
    }
}
