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
                    UserId = new Guid("cd927f96-1390-419a-b0f3-e6d5b3e390f5"),
                    UserName = "vdt56",
                    Age = 26,
                    OrganizationId = new Guid("4a6bc4c4-fa7c-4f72-aba4-4ffc2f78636e")
                },
                new User {
                    UserId = new Guid("5c93b2d2-b8f0-4cb6-bb1f-3e082b2934a4"),
                    UserName = "vdt5624",
                    Age = 30,
                    OrganizationId = new Guid("fed52094-2e33-4ab0-875c-2ba4a654044f")
                },
                 new User {
                     UserId = new Guid("26aa7e79-26fa-46d1-96b9-613c456465e7"),
                     UserName = "vdt5262",
                     Age = 35,
                     OrganizationId = new Guid("6fd20552-7030-4767-9bf8-dd8ca2ab8c30")
                 }
            );
        }
    }
}