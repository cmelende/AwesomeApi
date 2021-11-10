using System;
using Domain.UnitOfWork;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IUserRepository userRepository)
        {
            Users = userRepository;
        }
        public IUserRepository Users { get; }
        public void Dispose()
        {
            try
            {
                Commit();
            }
            catch (Exception e)
            {
                Rollback();
            }
        }

        public void Commit()
        {
            //commit
        }

        public void Rollback()
        {
            //rollback
        }
    }
}