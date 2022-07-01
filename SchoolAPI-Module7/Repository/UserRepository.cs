using System;
using Contracts;
using Entities.Models;
using Entities;
namespace Repository {
    public class UserRepository : RepositoryBase<Users>, IUserRepository {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext) {
        }
    }
}
