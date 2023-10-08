namespace ams.data.Context
{
    using ams.entity.Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection;

    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Housing> Housings { get; set; }
        public DbSet<HousingSafe> HousingSafes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Debit> Debits { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
