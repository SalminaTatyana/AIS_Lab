using AIS_Lab.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.DBModels
{
    public class File
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long UserId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public long FileSectionId { get; set; }
    }
}
