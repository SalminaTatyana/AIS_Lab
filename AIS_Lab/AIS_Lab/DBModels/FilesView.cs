using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.DBModels
{
    public class FilesView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long UserId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public long FileSectionId { get; set; }
        public string SectionName { get; set; }
    }
}
