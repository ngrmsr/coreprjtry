using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Entities;

namespace Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF.Configurations
{
    public class AccountConfig : IEntityTypeConfiguration<AccountModel>
    {
        public void Configure(EntityTypeBuilder<AccountModel> builder)
        {
            builder.HasKey(a => a.AccountModelId);
            //builder.HasOne(a=>a.user).WithMany(a=>a)
            builder.OwnsOne(a => a.address);
            builder.Property<DateTime>("createDate");
            builder.ToTable("Account");
        }
    }
}
