using System;

namespace Domain.UnitOfWork
{
    
    //Placed in the domain layer b/c we need our domain services (ie business logic) to know about these interfaces to use dependency injection
    public interface IUnitOfWork
        : IDisposable //optional, there are arguments for and against using this interface
    {
        public IUserRepository Users { get; }
        public void Commit();
        public void Rollback();
    }
}