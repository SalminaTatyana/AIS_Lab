using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.DBModels
{
    public class Applications
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long SectionId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string InstituteName { get; set; }
        public string FacultyName { get; set; }
        public string SpecializationName { get; set; }
        public string Course { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SkypeName { get; set; }
        public string GitLink { get; set; }
        public string WorkExperience { get; set; }
        public string FieldOfActivity { get; set; }
    }
}
