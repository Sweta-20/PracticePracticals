using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class propertiesteam
    {
        public Int64 id { get; set; }
        public string profile_photo { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string role_type { get; set; }
        public string post { get; set; }
        public string about { get; set; }
        public Int64 mobile { get; set; }
        public char flag { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
    }
}
