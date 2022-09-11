using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.DBModels
{
    public class RightView
    {
        public long Id { get; set; }
        public string RightName { get; set; }
        public long? RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
