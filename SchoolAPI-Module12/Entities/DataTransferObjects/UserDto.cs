using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects {
    public class UserDto {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
    }
}
