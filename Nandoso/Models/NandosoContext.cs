using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Nandoso.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class NandosoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
        public class myConfiguration : DbMigrationsConfiguration<NandosoContext>
        {
            public myConfiguration()
            {
                this.AutomaticMigrationsEnabled = true;
                this.AutomaticMigrationDataLossAllowed = true;
            }
        }

        public NandosoContext() : base("name=NandosoContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NandosoContext, myConfiguration>());
        }

        public System.Data.Entity.DbSet<Nandoso.Models.Person> People { get; set; }

        public System.Data.Entity.DbSet<Nandoso.Models.Feedback> Feedbacks { get; set; }
    }
}
