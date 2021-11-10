using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.UnitOfWork;
using MediatR;

namespace AwesomeApi.Handlers.Queries
{
    public class FindUserByNameQueryHandler : IRequestHandler<FindUserByNameQuery, IEnumerable<User>>
    {
        private readonly IUnitOfWork _uow;

        public FindUserByNameQueryHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public Task<IEnumerable<User>> Handle(FindUserByNameQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<User> users = _uow.Users.GetAll().Where(user => user.Name == request.Name);
            return Task.FromResult(users);
        }
    }

    public class FindUserByNameQuery : IRequest<IEnumerable<User>>
    {
        public string Name { get; set; }
    }
    
}