﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace integrationWPF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class integrationWPFEntities : DbContext
    {
        private static integrationWPFEntities _context;
        public integrationWPFEntities()
            : base("name=integrationWPFEntities")
        {
        }
    
        public static integrationWPFEntities GetContext()
        {
            if (_context == null)
                _context = new integrationWPFEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cities> cities { get; set; }
        public virtual DbSet<@class> @class { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<OrderAero> OrderAero { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<administrator> administrator { get; set; }
    }
}
