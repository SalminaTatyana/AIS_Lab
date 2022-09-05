using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AIS_Lab.Database
{
    [Table("Applications", Schema = "scientia")]
    public partial class Application
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("created", TypeName = "datetime")]
        public DateTime Created { get; set; }
        [Column("sectionId")]
        public long SectionId { get; set; }
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
        [Column("dateOfBirth", TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [Column("phoneNumber")]
        [StringLength(11)]
        public string PhoneNumber { get; set; }
        [Column("instituteName")]
        [StringLength(255)]
        public string InstituteName { get; set; }
        [Column("facultyName")]
        [StringLength(255)]
        public string FacultyName { get; set; }
        [Column("specializationName")]
        [StringLength(255)]
        public string SpecializationName { get; set; }
        [Column("course")]
        [StringLength(5)]
        public string Course { get; set; }
        [Column("startDate", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("endDate", TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column("skypeName")]
        [StringLength(255)]
        public string SkypeName { get; set; }
        [Column("gitLink")]
        public string GitLink { get; set; }
        [Column("workExperience")]
        [StringLength(5)]
        public string WorkExperience { get; set; }
        [Column("fieldOfActivity")]
        [StringLength(255)]
        public string FieldOfActivity { get; set; }

        [ForeignKey(nameof(SectionId))]
        [InverseProperty(nameof(SectionsOfTheSite.Applications))]
        public virtual SectionsOfTheSite Section { get; set; }
    }
}
