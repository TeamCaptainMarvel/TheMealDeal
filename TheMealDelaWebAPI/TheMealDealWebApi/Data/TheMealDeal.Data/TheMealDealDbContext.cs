namespace TheMealDeal.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class TheMealDealDbContext : IdentityDbContext<User>
    {
        public TheMealDealDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Recipe> Recipes { get; set; }
        public virtual IDbSet<Ingredient> Ingredients { get; set; }

        public static TheMealDealDbContext Create()
        {
            return new TheMealDealDbContext();
        }
    }
}
