﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessCenterAspNetMVCApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_FitnessCenterWebEntities : DbContext
    {
        public DB_FitnessCenterWebEntities()
            : base("name=DB_FitnessCenterWebEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Abonement> Abonement { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Coach> Coach { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<GroupService> GroupService { get; set; }
        public virtual DbSet<PersonalService> PersonalService { get; set; }
        public virtual DbSet<Service> Service { get; set; }
    }
}
