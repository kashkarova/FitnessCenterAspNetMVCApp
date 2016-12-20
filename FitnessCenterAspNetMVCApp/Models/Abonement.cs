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

        [DataType(DataType.Date)]
        public DateTime date_begin { get; set; }

        public int service_id { get; set; }

        [DataType(DataType.Date)]
        public DateTime date_end { get; set; }

        public int a_count { get; set; }

        public virtual Client Client { get; set; }

        public virtual Service Service { get; set; }

        public Abonement() { }

        public Abonement(int client, DateTime date_b, int service, DateTime date_e, int count)
        {
            client_id = client;
            date_begin=date_b;
            service_id = service;
            date_end = date_e;
            a_count = count;
        }
    }
}
