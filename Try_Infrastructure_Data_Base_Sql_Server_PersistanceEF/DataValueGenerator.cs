using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF
{
    public class DataValueGenerator : ValueGenerator<DateTime>
    {
        public override bool GeneratesTemporaryValues => false;

        public override DateTime Next(EntityEntry entry)
        {
            return DateTime.Now;
        }
    }
}
