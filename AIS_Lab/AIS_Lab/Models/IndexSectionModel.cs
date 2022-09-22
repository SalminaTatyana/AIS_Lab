using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.Models
{
    public class IndexSectionModel
    {
        public string BlockTitle { get; set; }
        public string Text { get; set; }
        public string[] List { get; set; }
        public string Img { get; set; }
        public bool IsButton { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }


    }
}
