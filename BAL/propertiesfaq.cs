using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
     public  class propertiesfaq
    {
       public Int64 faq_id { get; set; }
       public string question { get; set; }
       public string answer { get; set; }
       public char flag { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
    }
}
