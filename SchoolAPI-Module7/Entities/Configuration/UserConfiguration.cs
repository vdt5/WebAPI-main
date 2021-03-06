using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration {
    public class UserConfiguration : IEntityTypeConfiguration<Users> {
        public void Configure(EntityTypeBuilder<Users> builder) {
            builder.HasData
            (
                new Users {
                    Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    UserName = "vdt5",
                    OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                new Users {
                    Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                    UserName = "vdt500",
                    OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                 new Users {
                     Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                     UserName = "vishalt",
                     OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                 }
            );

        }
    }
}
