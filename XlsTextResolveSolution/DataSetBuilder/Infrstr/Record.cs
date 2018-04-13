using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetCreater.Infrstr
{
    public class Record
    {
        public string PathToCtrl { get; set; }
        public DateTime CreateDate { get; set; }
        public string Text { get; set; }
        public string DbField { get; set; }
        public string Table { get; set; }
    }
}
