using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AIS_Lab.Database
{
    [Table("Files", Schema = "scientia")]
    public partial class File
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("created", TypeName = "datetime")]
        public DateTime Created { get; set; }
        [Column("userId")]
        public long UserId { get; set; }
        [Required]
        [Column("fileName")]
        [StringLength(255)]
        public string FileName { get; set; }
        [Required]
        [Column("filePath")]
        public string FilePath { get; set; }
        [Column("fileSectionId")]
        public long FileSectionId { get; set; }

        [ForeignKey(nameof(FileSectionId))]
        [InverseProperty(nameof(SectionsOfTheSite.Files))]
        public virtual SectionsOfTheSite FileSection { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Files")]
        public virtual User User { get; set; }
    }
}
