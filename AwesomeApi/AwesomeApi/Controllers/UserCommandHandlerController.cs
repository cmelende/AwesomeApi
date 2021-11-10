using System.Collections.Generic;
using System.Threading.Tasks;
using AwesomeApi.Handlers.Queries;
using Domain.Entities;
using Domain.UnitOfWork;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserCommandHandlerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserCommandHandlerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<User>> GetCory(User user)
        {
            var query = new FindUserByNameQuery
            {
                Name = "cory"
            };

            return _mediator.Send(query);
        }
    }
}