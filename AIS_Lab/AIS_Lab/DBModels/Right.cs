using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.DBModels
{
    public class Right
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? RoleId { get; set; }
    }
}
