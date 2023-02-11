using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class propertiesuser
    {
        public Int64 user_id { get; set; }
        public Int64 role_id {get; set;}
        public string fname { get; set; }
        public string lname { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string adress { get; set; }
        public Int64 mobile { get; set; }
        public string password { get; set; }
        public string profile_photo{ get; set; }
        public DateTime birthdate { get; set; }
        public DateTime created_date { get; set; }
        public char flag { get; set; }
        public DateTime updated_date { get; set; }
    }
}
