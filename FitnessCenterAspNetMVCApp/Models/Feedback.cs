namespace FitnessCenterAspNetMVCApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        [Key]
        public int f_id { get; set; }

        [Required]
        [StringLength(30)]
        public string f_name { get; set; }

        [Required]
        [StringLength(20)]
        public string f_email { get; set; }

        [Required]
        [StringLength(255)]
        public string f_message { get; set; }
    }
}
