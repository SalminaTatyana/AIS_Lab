using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AIS_Lab.Database
{
    [Keyless]
    public partial class UserRightsView
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("userId")]
        public long UserId { get; set; }
        [Column("fio")]
        [StringLength(767)]
        public string Fio { get; set; }
        [Required]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("rightId")]
        public long RightId { get; set; }
        [Required]
        [Column("rightName")]
        [StringLength(255)]
        public string RightName { get; set; }
    }
}
