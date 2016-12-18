using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCenterAspNetMVCApp.Models
{
    public partial class AddNewAbonement
    {
        public string c_surname { get; set; }

        public string c_name { get; set; }

        public string c_phone { get; set; }

        public string s_title { get; set; }

        public int a_count { get; set; }

        public DateTime date_begin { get; set; }

        public DateTime date_end { get; set; }

        
    }
}