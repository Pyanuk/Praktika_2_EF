﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Praktika_1_EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class COFFEE_HOUSEEntities : DbContext
    {
        public COFFEE_HOUSEEntities()
            : base("name=COFFEE_HOUSEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CLIENT> CLIENT { get; set; }
        public virtual DbSet<CUSTOMER_ORDER> CUSTOMER_ORDER { get; set; }
        public virtual DbSet<NAME_COFFEE> NAME_COFFEE { get; set; }
        public virtual DbSet<ORDER_COFFEE> ORDER_COFFEE { get; set; }
    }
}