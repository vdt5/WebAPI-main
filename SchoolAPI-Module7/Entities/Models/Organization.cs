﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models {
    public class Organization {
        [Column("OrganizationId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Organization name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string OrgName { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
