using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF
{
    public class Contextfactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<MyContext> options = new DbContextOptionsBuilder<MyContext>();
            options.UseSqlServer("Password=22552111;Persist Security Info=True;User ID=sa;Initial Catalog=EFTestBank;Data Source=.");
            return new MyContext(options.Options);
        }
    }
}
