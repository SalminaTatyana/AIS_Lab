using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AIS_Lab.Database
{
    [Table("SectionsOfTheSite", Schema = "scientia")]
    public partial class SectionsOfTheSite
    {
        public SectionsOfTheSite()
        {
            Applications = new HashSet<Application>();
            Files = new HashSet<File>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }

        [InverseProperty(nameof(Application.Section))]
        public virtual ICollection<Application> Applications { get; set; }
        [InverseProperty(nameof(File.FileSection))]
        public virtual ICollection<File> Files { get; set; }
    }
}
