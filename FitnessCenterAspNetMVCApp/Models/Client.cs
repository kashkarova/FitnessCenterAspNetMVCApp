namespace FitnessCenterAspNetMVCApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Abonement = new HashSet<Abonement>();
        }

        public Client(string name, string surname, string phone)
        {
            c_name = name;
            c_surname = surname;
            c_phone = phone;
        }

        [Key]
        public int c_id { get; set; }

        [Required]
        [StringLength(30)]
        public string c_surname { get; set; }

        [Required]
        [StringLength(30)]
        public string c_name { get; set; }

        [Required]
        [StringLength(11)]
        public string c_phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abonement> Abonement { get; set; }
    }
}
