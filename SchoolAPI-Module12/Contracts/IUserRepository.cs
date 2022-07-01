using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts {
    public interface IUserRepository {
        IEnumerable<User> GetAllUsers(bool trackChanges);
        User GetUser(Guid UserId, bool trackChanges);
        void CreateUser(User user);
        IEnumerable<User> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        void DeleteUser(User user);
    }
}
