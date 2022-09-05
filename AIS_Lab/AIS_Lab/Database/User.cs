using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AIS_Lab.Database
{
    [Table("Users", Schema = "scientia")]
    public partial class User
    {
        public User()
        {
            Files = new HashSet<File>();
            UserRights = new HashSet<UserRight>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("lastName")]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        [Column("firstName")]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
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

        [ForeignKey(nameof(RoleId))]
        [InverseProperty("Users")]
        public virtual Role Role { get; set; }
        [InverseProperty(nameof(File.User))]
        public virtual ICollection<File> Files { get; set; }
        [InverseProperty(nameof(UserRight.User))]
        public virtual ICollection<UserRight> UserRights { get; set; }
    }
}
