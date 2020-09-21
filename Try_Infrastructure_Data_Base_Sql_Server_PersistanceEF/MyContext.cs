using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Entities;
using Try_Core_Entities.Model;
using Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF.Configurations;

namespace Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF
{
   public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext>options):base(options)
        {

        }
        public MyContext()
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Password = 22552111; Persist Security Info = True; User ID = sa; Initial Catalog = EFTestBank; Data Source =.")
        //    base.OnConfiguring(optionsBuilder);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfig());
            modelBuilder.ApplyConfiguration(new LoanConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
        }
        public DbSet<UserModel> UserModel { get; set; }
        public DbSet<AccountModel> AccountModel { get; set; }
        public DbSet<LoanModel> LoanModel { get; set; }
        public DbSet<AccountLoanModel> AccountLoan { get; set; }
    }
}
