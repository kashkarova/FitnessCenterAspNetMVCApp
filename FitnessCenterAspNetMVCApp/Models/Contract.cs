namespace FitnessCenterAspNetMVCApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        [Key]
        public int contr_id { get; set; }

        public int service_id { get; set; }

        public int coach_id { get; set; }

        public int contr_salary { get; set; }

        public virtual Coach Coach { get; set; }

        public virtual Service Service { get; set; }
    }
}
