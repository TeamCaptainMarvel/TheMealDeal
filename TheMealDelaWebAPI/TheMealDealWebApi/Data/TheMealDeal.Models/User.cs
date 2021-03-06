﻿

namespace TheMealDeal.Models
{
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using Common.Constants;
    public class User : IdentityUser
    {
        private ICollection<Recipe> favourites;
        private ICollection<Recipe> myRecipes;

        public User()
        {
            this.favourites = new HashSet<Recipe>();
            this.myRecipes = new HashSet<Recipe>();
        }
        [MaxLength(ValidationConstants.UserNameMaxLenght)]
        public string Firstname { get; set; }

        [MaxLength(ValidationConstants.UserNameMaxLenght)]
        public string Lastname { get; set; }

        public ICollection<Recipe> Favourites
        {
            get { return this.favourites; }
            set { this.favourites = value; }
        }
        
        public ICollection<Recipe> MyRecipes
        {
            get { return this.myRecipes; }
            set { this.myRecipes = value; }
        }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
