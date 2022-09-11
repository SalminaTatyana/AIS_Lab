using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.DBModels
{
    public class UserRight
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long RightId { get; set; }
    }
}
