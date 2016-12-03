using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessCenterAspNetMVCApp.Models
{
    public partial class Abonement
    {

        [Key]
        public int a_id { get; set; }

        [Required]
        public int client_id { get; set; }

        [Required]
        public System.DateTime date_begin { get; set; }

        [Required]
        public int service_id { get; set; }

        [Required]
        public System.DateTime date_end { get; set; }

        [Required]
        public int a_count { get; set; }

        public virtual Client Client { get; set; }
        public virtual Service Service { get; set; }
    }
}