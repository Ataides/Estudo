namespace UIConsole.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<UIConsole.DbSelvagem>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "UIConsole.DbSelvagem";
        }

        protected override void Seed(UIConsole.DbSelvagem context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
