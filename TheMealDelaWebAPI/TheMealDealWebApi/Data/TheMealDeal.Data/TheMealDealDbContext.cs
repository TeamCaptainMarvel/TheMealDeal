namespace TheMealDeal.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class TheMealDealDbContext : IdentityDbContext<User>
    {
        public TheMealDealDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static TheMealDealDbContext Create()
        {
            return new TheMealDealDbContext();
        }
    }
}
