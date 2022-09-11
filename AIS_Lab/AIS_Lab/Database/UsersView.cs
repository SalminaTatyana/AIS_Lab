using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AIS_Lab.Database
{
    [Keyless]
    public partial class UsersView
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("lastName")]
        [StringLength(255)]
        public string LastName { get; set; }
        [Column("firstName")]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Column("middleName")]
        [StringLength(255)]
        public string MiddleName { get; set; }
        [Required]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("passwordHash")]
        [StringLength(256)]
        public string PasswordHash { get; set; }
        [Column("isLocked")]
        public bool IsLocked { get; set; }
        [Column("phoneNumber")]
        [StringLength(11)]
        public string PhoneNumber { get; set; }
        [Column("dateRegistration", TypeName = "datetime")]
        public DateTime? DateRegistration { get; set; }
        [Column("roleId")]
        public long RoleId { get; set; }
        [Required]
        [Column("roleName")]
        [StringLength(255)]
        public string RoleName { get; set; }
    }
}
