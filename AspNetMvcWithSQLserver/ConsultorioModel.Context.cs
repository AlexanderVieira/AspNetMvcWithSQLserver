﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetMvcWithSQLserver
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ConsultorioEntities : DbContext
    {
        public ConsultorioEntities()
            : base("name=ConsultorioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CONSULTA> CONSULTA { get; set; }
        public virtual DbSet<HOSPITAL> HOSPITAL { get; set; }
        public virtual DbSet<INTERNACAO> INTERNACAO { get; set; }
        public virtual DbSet<MEDICO> MEDICO { get; set; }
        public virtual DbSet<PACIENTE> PACIENTE { get; set; }
    }
}
