namespace FitnessCenterAspNetMVCApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimetableView")]
    public partial class TimetableView
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        [Display(Name ="Услуга")]
        public string s_title { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(61)]
        [Display(Name = "Тренер")]
        public string coach { get; set; }
    }
}
