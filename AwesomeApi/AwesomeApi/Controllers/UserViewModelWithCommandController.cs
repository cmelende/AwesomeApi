
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AwesomeApi.Handlers.Queries;
using AwesomeApi.ViewModels;
using Domain.Entities;
using Domain.UnitOfWork;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserViewModelWithHandlerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public UserViewModelWithHandlerController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<UserViewModel>> GetByName(string name)
        {
            var command = new FindUserByNameQuery{ Name = name};
            IEnumerable<User> results = await _mediator.Send(command);

            return results.Select(user => _mapper.Map<UserViewModel>(user));
        }
    }
}