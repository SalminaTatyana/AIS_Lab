using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.DBModels
{
    public class UserRightsView
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Fio { get; set; }
        public string Email { get; set; }
        public long RightId { get; set; }
        public string RightName { get; set; }
    }
}
