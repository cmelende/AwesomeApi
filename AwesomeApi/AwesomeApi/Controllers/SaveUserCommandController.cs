using System.Threading.Tasks;
using AwesomeApi.Handlers.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeApi.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class SaveUserCommandController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SaveUserCommandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task Save(SaveUserViewModel viewModel)
        {
            var command = new SaveUserCommand
            {
                Email = viewModel.Email,
                Name = viewModel.Name,
                Password = viewModel.Password,
                Username = viewModel.Username
            };

            await _mediator.Send(command);
        }
        
    }

    public class SaveUserViewModel
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}