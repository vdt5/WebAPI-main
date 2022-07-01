using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities {
    public class RepositoryContext : DbContext {
        public RepositoryContext(DbContextOptions options)
            : base(options) {}


        public DbSet<Organization> Organizations { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
