﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityUrunTakipSistemi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EntityUrunTakipEntities : DbContext
    {
        public EntityUrunTakipEntities()
            : base("name=EntityUrunTakipEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CategoryTable> CategoryTable { get; set; }
        public virtual DbSet<CustomerTable> CustomerTable { get; set; }
        public virtual DbSet<ProductTable> ProductTable { get; set; }
        public virtual DbSet<SaleTable> SaleTable { get; set; }
        public virtual DbSet<AdminTable> AdminTable { get; set; }
    
        public virtual ObjectResult<string> MARKAGETIR()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("MARKAGETIR");
        }
    }
}
