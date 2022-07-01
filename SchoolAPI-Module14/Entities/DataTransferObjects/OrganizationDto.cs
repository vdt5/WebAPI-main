using System;

namespace Entities.DataTransferObjects {
    public class OrganizationDto {
        public Guid Id { get; set; }
        public string OrgName { get; set; }
        public string FullAddress { get; set; }
    }
}
