﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _0._99_money_machine_console_app
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AtmDBContextEntities : DbContext
    {
        public AtmDBContextEntities()
            : base("name=AtmDBContextEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Deposit> Deposits { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Withdrawl> Withdrawls { get; set; }
    }
}
