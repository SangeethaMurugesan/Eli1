﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoctorAppo.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class doctorappoEntities4 : DbContext
    {
        public doctorappoEntities4()
            : base("name=doctorappoEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Logi> Logis { get; set; }
        public virtual DbSet<tblPatientDetail> tblPatientDetails { get; set; }
        public virtual DbSet<feedback> feedbacks { get; set; }
    }
}