using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class propertiesforgot
    {
        public Int64 f_id { get; set; }
        public Int64 user_id { get; set; }
        public string email { get; set; }
        public string token { get; set; }
        public DateTime expire_date { get; set; }
        public string n_pswd { get; set; }
        public char flag { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
    }
}
