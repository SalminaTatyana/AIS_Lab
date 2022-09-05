using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AIS_Lab.Database
{
    [Keyless]
    public partial class RightView
    {
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("rightName")]
        [StringLength(255)]
        public string RightName { get; set; }
        [Column("roleId")]
        public long? RoleId { get; set; }
        [Required]
        [Column("roleName")]
        [StringLength(255)]
        public string RoleName { get; set; }
    }
}
