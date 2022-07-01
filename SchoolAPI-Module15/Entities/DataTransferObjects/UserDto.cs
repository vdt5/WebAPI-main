using System;

namespace Entities.DataTransferObjects {
    public class UserDto {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
    }
}
