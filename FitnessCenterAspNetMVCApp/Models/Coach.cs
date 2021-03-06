namespace FitnessCenterAspNetMVCApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Coach")]
    public partial class Coach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Coach()
        {
            Contract = new HashSet<Contract>();
        }

        [Key]
        public int coach_id { get; set; }

        [Required]
        [StringLength(30)]
        public string coach_surname { get; set; }

        [Required]
        [StringLength(30)]
        public string coach_name { get; set; }

        [Required]
        [StringLength(30)]
        public string coach_post { get; set; }

        [StringLength(255)]
        public string coach_skill { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contract { get; set; }
    }
}
