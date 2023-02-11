using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class propertiesalbum
    {
        public Int64 albumId { get; set; }
        public string title { get; set; }
        public string coverphoto { get; set; }
        public DateTime created_date { get; set; }
        public char flag { get; set; }
        public DateTime updated_date { get; set; }
    }
}
