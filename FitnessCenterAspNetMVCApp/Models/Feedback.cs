using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessCenterAspNetMVCApp.Models
{
    public partial class Feedback
    {
        [Key]
        public int f_id { get; set; }

        [Required]
        public string f_name { get; set; }

        [Required]
        public string f_email { get; set; }

        [Required]
        public string f_message { get; set; }
    }
}