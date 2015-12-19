namespace TheMealDeal.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity;
    public class TheMealDealDbContext : IdentityDbContext<User>
    {
        public TheMealDealDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Recipe> Recipes { get; set; }

        public static TheMealDealDbContext Create()
        {
            return new TheMealDealDbContext();
        }
    }
}
