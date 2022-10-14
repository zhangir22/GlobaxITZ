using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobaxIT.Models.Model
{
    public class UserModel
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string position_name { get; set; }
        public string department { get; set; }
        public DateTime hire_date { get; set; }
    }
}