using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.UnitOfWork;

namespace Infrastructure
{
    public class UserRepository : IUserRepository
    {
        public User Get(int id)
        {
            return new()
            {
                Id = id, Email = "cory.melendez@tylertech.com", Name = "cory melendez", Password = "myPw",
                Username = "cory.melendez"
            };
        }

        public IEnumerable<User> GetAll()
        {
            return new List<User>
            {
                new()
                {
                    Id = 1, Email = "cory.melendez@tylertech.com", Name = "cory melendez", Password = "myPw",
                    Username = "cory.melendez"
                }
            };
        }

        public void Save(User entity)
        {
            //Save user
        }

        public void Update(User entity)
        {
            //Update user
        }

        public void Delete(User entity)
        {
            //delete user
        }
    }
}