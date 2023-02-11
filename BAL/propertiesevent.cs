using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class propertiesevent
    {
        public Int64 Ev_ID { get; set; }
        public string photo_path { get; set; }
        public string ev_name { get; set; }
        public DateTime ev_date { get; set; }
        public string place { get; set; }
    
        public string descript { get; set; }
        public char flag { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
    }
}
