﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logamoasta
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LogamoastaEntities : DbContext
    {
        public LogamoastaEntities()
            : base("name=LogamoastaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Lagerbestand> Lagerbestand { get; set; }
        public DbSet<Lagerverlauf> Lagerverlauf { get; set; }
        public DbSet<Mitarbeiter> Mitarbeiter { get; set; }
    }
}
