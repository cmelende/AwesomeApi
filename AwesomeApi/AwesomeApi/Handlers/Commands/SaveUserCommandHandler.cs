using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.UnitOfWork;
using MediatR;

namespace AwesomeApi.Handlers.Commands
{
    public class SaveUserCommandHandler : IRequestHandler<SaveUserCommand, SaveUserCommandResults>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMediator _mediator;

        public SaveUserCommandHandler(IUnitOfWork uow, IMediator mediator)
        {
            _uow = uow;
            _mediator = mediator;
        }
        public Task<SaveUserCommandResults> Handle(SaveUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Username = request.Username,
                Email = request.Email,
                Name = request.Name,
                Password = request.Password
            };
            _uow.Users.Save(user);
            _mediator.Publish(new SaveUserNotification{ User = user}, cancellationToken);

            return Task.FromResult(new SaveUserCommandResults {Success = true});
        }
    }

    public class SaveUserCommand : IRequest<SaveUserCommandResults>, INotification
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }

    public class SaveUserCommandResults
    {
        public bool Success { get; set; }
    }
}