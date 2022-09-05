using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AIS_Lab.Database
{
    [Keyless]
    public partial class FilesView
    {
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
        [Required]
        [Column("sectionName")]
        [StringLength(255)]
        public string SectionName { get; set; }
    }
}
