using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class propertiesphoto
    {
        public Int64 photo_ID { get; set; }
        public Int64 Album_ID { get; set; }
        public string title { get; set; }
        public string photo_path { get; set; }
        public DateTime created_date { get; set; }
        public char flag { get; set; }
        public DateTime updated_date { get; set; }
    }
}
