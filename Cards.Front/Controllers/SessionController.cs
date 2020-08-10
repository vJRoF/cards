using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cards.DataAccess;
using Cards.Front.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cards.Front.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;

        public SessionController(
            IMapper mapper,
            AppDbContext dbContext)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        /// <summary>
        ///     Создать новый сеанс
        /// </summary>
        /// <param name="sessionName">Имя сеанса</param>
        [HttpPost("create")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SessionModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        public async Task<IActionResult> Create(
            [Required, MinLength(1)] string sessionName)
        {
            var newSession = new Session
            {
                Id = Guid.NewGuid(),
                Name = sessionName,
                Created = DateTimeOffset.Now,
                Modified = DateTimeOffset.Now
            };

            _dbContext.Sessions.Add(newSession);
            await _dbContext.SaveChangesAsync(HttpContext.RequestAborted);

            return Ok(_mapper.Map<SessionModel>(newSession));
        }

        /// <summary>
        ///     Получить список сеансов с постраничным выводом
        /// </summary>
        /// <param name="limit">Сколько взять</param>
        /// <param name="offset">Сколько пропустить</param>
        [HttpGet("list")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Session[]))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        public async Task<IActionResult> List(
            int limit,
            int offset)
        {
            var sessions = await _dbContext.Sessions
                //.OrderByDescending(s => s.Modified)
                .Skip(offset)
                .Take(limit)
                .ToArrayAsync(HttpContext.RequestAborted);

            return Ok(_mapper.Map<Session[]>(sessions));
        }
    }
}