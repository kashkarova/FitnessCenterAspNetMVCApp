using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessCenterAspNetMVCApp.Models
{
    public partial class Contract
    {
        [Key]
        public int contr_id { get; set; }

        [Required]
        public int service_id { get; set; }

        [Required]
        public int coach_id { get; set; }

        [Required]
        public int contr_salary { get; set; }

        public virtual Coach Coach { get; set; }
        public virtual Service Service { get; set; }
    }
}