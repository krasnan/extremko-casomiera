﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace perfectTiming.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class perfecttimingEntities : DbContext
    {
        public perfecttimingEntities()
            : base("name=perfecttimingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Competitor> Competitors { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Timing> Timings { get; set; }
    }
}