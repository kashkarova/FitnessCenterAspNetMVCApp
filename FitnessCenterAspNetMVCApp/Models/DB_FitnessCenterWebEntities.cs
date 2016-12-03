using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace FitnessCenterAspNetMVCApp.Models
{

    public partial class DB_FitnessCenterWebEntities : DbContext
    {
        public DB_FitnessCenterWebEntities()
            : base("name=DB_FitnessCenterWebEntities")
        {
        }

        public virtual DbSet<Abonement> Abonement { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Coach> Coach { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Service> Service { get; set; }
    }
}
