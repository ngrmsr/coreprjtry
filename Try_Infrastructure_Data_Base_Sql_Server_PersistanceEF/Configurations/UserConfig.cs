using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Entities;

namespace Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.HasKey(a => a.UserModelId);
            //builder.Property(a => a.PassWord).HasField("PassWord");
            builder.Property<DateTime>("createDate");
            builder.ToTable("User");
        }
    }
}
