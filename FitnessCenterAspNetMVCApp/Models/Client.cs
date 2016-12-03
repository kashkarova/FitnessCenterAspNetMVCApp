using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessCenterAspNetMVCApp.Models
{
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Abonement = new HashSet<Abonement>();
        }

        [Key]
        public int c_id { get; set; }

        [Required]
        public string c_surname { get; set; }

        [Required]
        public string c_name { get; set; }

        public string c_phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abonement> Abonement { get; set; }
    }
}