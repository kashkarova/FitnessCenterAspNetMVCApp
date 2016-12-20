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
        [Display(Name ="Name")]
        public string f_name { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "E-mail")]
        public string f_email { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Длина строки должна быть до 255 символов")]
        [Display(Name = "Your feedback")]
        public string f_message { get; set; }
    }
}
