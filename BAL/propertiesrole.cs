using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class propertiesrole
    {
        public Int64 role_id { get; set; }
        public string role_type { get; set; }
        public DateTime created_date { get; set; }
        public char flag { get; set; }
        public DateTime updated_date { get; set; }
    }
}
