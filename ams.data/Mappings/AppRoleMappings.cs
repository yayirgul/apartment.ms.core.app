namespace ams.data.Mappings
{
    using ams.entity.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AppRoleMappings : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            // Primary key
            builder.HasKey(r => r.Id);

            // Index for "normalized" role name to allow efficient lookups
            builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

            // Maps to the AspNetRoles table
            builder.ToTable("AspNetRoles");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(256);
            builder.Property(u => u.NormalizedName).HasMaxLength(256);

            // The relationships between Role and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each Role can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.HasData(new AppRole
            {
                Id = Guid.Parse("4271DD20-390A-46CE-B67D-59678A720270"),
                Name = "admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "020befa1-6390-4af6-885a-9fb6e883ab71",
            },
            new AppRole
            {
                Id = Guid.Parse("4438DFF4-28D6-46C1-90EB-F6B2A233D97E"),
                Name = "agent",
                NormalizedName = "AGENT",
                ConcurrencyStamp = "83fd2ba2-cd51-4339-ae6e-7a9baa435c4d",
            },
            new AppRole
            {
                Id = Guid.Parse("051004F1-A383-4746-A722-3B051D12AAEA"),
                Name = "user",
                NormalizedName = "USER",
                ConcurrencyStamp = "b2dfd302-b41b-4732-b490-9bc065947992",
            }
            );
        }
    }
}
