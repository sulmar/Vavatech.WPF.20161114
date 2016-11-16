using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Bicycle.Interfaces;
using Vavatech.Bicycle.Models;

namespace Vavatech.Bicykle.MockServices
{
    public class MockUsersService : IUsersService
    {
        private readonly IList<User> _Users = new List<User>
        {
            new User { UserId = 1, FirstName = "Marcin", LastName = "Sulecki" },
            new User { UserId = 2, FirstName = "Bartosz", LastName = "Sulecki" },
        };

        public void Add(User item)
        {
            _Users.Add(item);
        }

        public IList<User> Get()
        {
            return _Users;
        }

        public User Get(int itemId)
        {
            return _Users.Single(u => u.UserId == itemId);
        }

        public Task<IList<User>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public void Remove(int itemId)
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
