using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.DBModels
{
    public class UsersView
    {
        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool IsLocked { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DateRegistration { get; set; }
        public long RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
