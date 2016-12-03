using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessCenterAspNetMVCApp.Models
{
    public partial class Coach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Coach()
        {
            this.Contract = new HashSet<Contract>();
        }

        [Key]
        public int coach_id { get; set; }

        [Required]
        public string coach_surname { get; set; }

        [Required]
        public string coach_name { get; set; }

        [Required]
        public string coach_post { get; set; }

        [Required]
        public string coach_skill { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contract { get; set; }
    }
}