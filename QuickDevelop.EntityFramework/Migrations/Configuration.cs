using System.Data.Entity.Migrations;
using QuickDevelop.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace QuickDevelop.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<QuickDevelop.EntityFramework.QuickDevelopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "QuickDevelop";
        }

        protected override void Seed(QuickDevelop.EntityFramework.QuickDevelopDbContext context)
        {
            context.DisableAllFilters();
            new InitialDataBuilder(context).Build();
        }
    }
}
