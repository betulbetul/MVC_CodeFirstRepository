namespace MVCCodeFirst.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCCodeFirst.DAL.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            // AutomaticMigrationDataLossAllowed = true; VERÝ KAYBINI ONAYLAMAK ANLAMINA GELÝYOR.
        }

        protected override void Seed(MVCCodeFirst.DAL.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
