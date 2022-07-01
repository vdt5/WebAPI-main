using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration {
    public class UserConfiguration : IEntityTypeConfiguration<User> {
        public void Configure(EntityTypeBuilder<User> builder) {
            builder.HasData
            (
                new User {
                    Id = new Guid("b3369db6-5446-4b01-973a-239d92410d1a"),
                    UserName = "vishalt",
                    OrganizationId = new Guid("744a27da-2697-4dda-808d-6b939aca820a")
                },
                new User {
                    Id = new Guid("b8c00ca8-8914-4494-b60d-f380f44963ae"),
                    UserName = "vdt535",
                    OrganizationId = new Guid("9795535a-c109-4b2f-8a64-27f94c2f1399")
                },
                 new User {
                     Id = new Guid("3bbb929a-1b10-4e3f-b837-1a2a0024f8fa"),
                     UserName = "vdt534",
                     OrganizationId = new Guid("e9019be7-30c8-4189-a6cf-94a7ecc74a84")
                 }
            );
        }
    }
}