using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class propertiespayment
    {
        public Int64 trans_id { get; set; }
        public string p_mode  {get; set;}
        public string status { get; set; }
        public Int64 amt { get; set; }
        public Int64 user_id { get; set; }

        public char flag { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }

    }
}
