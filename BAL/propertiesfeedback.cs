using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class propertiesfeedback
    {
        public Int64 fb_id { get; set; }
        public string user_name { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string msg { get; set; }
        public char flag { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
    }
}
