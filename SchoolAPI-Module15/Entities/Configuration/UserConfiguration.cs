using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration {
    public class UserConfiguration : IEntityTypeConfiguration<User> {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
                new User
                {
                    UserID = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    Name = "vishalt",
                    Age = 21,
                    OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                new User
                {
                    UserID = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                    Name = "vdt563",
                    Age = 25,
                    OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                 new User
                 {
                     UserID = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                     Name = "vdt1265",
                     Age = 28,
                     OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                 }
            );
        }
    }
}