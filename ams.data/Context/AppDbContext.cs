namespace ams.data.Context
{
    using ams.entity.Entities;
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Housing> Housings { get; set; }
    }
}
