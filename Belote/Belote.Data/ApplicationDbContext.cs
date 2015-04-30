namespace Belote.Data
{
    using System.Data.Entity;
    using System.Linq;

    using Microsoft.AspNet.Identity.EntityFramework;

    using Belote.Models;
    using Belote.Data.Migrations;
    using Belote.Models.Contracts;
    using System;

    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        
        }

        public IDbSet<Game> Games { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public override int SaveChanges()
        {
            this.ApplyCreatableRules();
            return base.SaveChanges();
        }

        private void ApplyCreatableRules()
        {
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(e => e.Entity is ICreatable &&
                            ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (ICreatable)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedOn = DateTime.Now;
                }
            }
        }
    }
}
