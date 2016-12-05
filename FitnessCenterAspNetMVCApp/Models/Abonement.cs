namespace FitnessCenterAspNetMVCApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Abonement")]
    public partial class Abonement
    {
        [Key]
        public int a_id { get; set; }

        public int client_id { get; set; }

        public DateTime date_begin { get; set; }

        public int service_id { get; set; }

        public DateTime date_end { get; set; }

        public int a_count { get; set; }

        public virtual Client Client { get; set; }

        public virtual Service Service { get; set; }
    }
}
