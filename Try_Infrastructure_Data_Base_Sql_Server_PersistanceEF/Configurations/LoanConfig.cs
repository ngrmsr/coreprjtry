using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Try_Core_Entities;

namespace Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF.Configurations
{
    public class LoanConfig : IEntityTypeConfiguration<LoanModel>
    {
        public void Configure(EntityTypeBuilder<LoanModel> builder)
        {
            builder.HasKey(a => a.LoanModelId);
            builder.Property<DateTime>("createDate");
            builder.ToTable("Loan");
        }
    }
}
