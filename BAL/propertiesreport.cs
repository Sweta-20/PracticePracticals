using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class propertiesreport
    {
        public Int64 r_id { get; set; }
     
        public string fname { get; set; }
        public string lname { get; set; }
        public Int64 contact { get; set; }
        public string address { get; set; }
        public string ev_id { get; set; }
        public Int64 amt { get; set; }
        public char flag { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
    }
}
