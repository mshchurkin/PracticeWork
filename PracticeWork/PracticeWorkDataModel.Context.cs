﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticeWork
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PracticeWorkDataModelContainer : DbContext
    {
        public PracticeWorkDataModelContainer()
            : base("name=PracticeWorkDataModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Model> ModelSet { get; set; }
        public virtual DbSet<Computer> ComputerSet { get; set; }
        public virtual DbSet<Device> DeviceSet { get; set; }
        public virtual DbSet<Server> ServerSet { get; set; }
        public virtual DbSet<Queue> QueueSet { get; set; }
        public virtual DbSet<Routine> RoutineSet { get; set; }
        public virtual DbSet<Router> RouterSet { get; set; }
        public virtual DbSet<Connection> ConnectionSet { get; set; }
    }
}
