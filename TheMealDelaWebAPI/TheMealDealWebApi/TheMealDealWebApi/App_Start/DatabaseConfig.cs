
namespace TheMealDealWebApi
{
    using System.Data.Entity;
    using TheMealDeal.Data;
    using TheMealDeal.Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TheMealDealDbContext, Configuration>());
            TheMealDealDbContext.Create().Database.Initialize(true);
        }
    }
}