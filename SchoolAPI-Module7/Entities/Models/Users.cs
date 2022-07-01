using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models {
    public class Users {
        [Column("UserId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "User name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the name is 30 characters")]

        public string UserName { get; set; }
        [ForeignKey(nameof(Organization))]

        public Guid OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
