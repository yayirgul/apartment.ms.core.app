namespace ams.data.Context
{
    using ams.entity.Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection;

    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Housing> Housings { get; set; }
        public DbSet<HousingSafe> HousingSafes { get; set; }
        public DbSet<HousingSafeMovement> HousingSafeMovements { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Debit> Debits { get; set; }
        public DbSet<AdxMenu> AdxMenus { get; set; }
        public DbSet<Year> Years { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            /*
             *  TODO : "IdentityDbContext" yapısını kullandığım için "base.OnModelCreating(builder)" nesnemi ekledim
             */

            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
