namespace FitnessCenterAspNetMVCApp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbModel : DbContext
    {
        public DbModel()
            : base("name=DbModel")
        {
        }

        public virtual DbSet<Abonement> Abonement { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Coach> Coach { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Service> Service { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.c_surname)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.c_name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.c_phone)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Abonement)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.client_id);

            modelBuilder.Entity<Coach>()
                .Property(e => e.coach_surname)
                .IsUnicode(false);

            modelBuilder.Entity<Coach>()
                .Property(e => e.coach_name)
                .IsUnicode(false);

            modelBuilder.Entity<Coach>()
                .Property(e => e.coach_post)
                .IsUnicode(false);

            modelBuilder.Entity<Coach>()
                .Property(e => e.coach_skill)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.f_name)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.f_email)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.f_message)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.s_title)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.s_description)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.Abonement)
                .WithRequired(e => e.Service)
                .HasForeignKey(e => e.service_id);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.Contract)
                .WithRequired(e => e.Service)
                .HasForeignKey(e => e.service_id);
        }
    }
}
