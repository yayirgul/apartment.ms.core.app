namespace ams.data.Mappings
{
    using ams.entity.Entities;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AppUserMappings : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            // Primary Key
            builder.HasKey(x => x.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

            var admin = new AppUser
            {
                Id = Guid.Parse("D719553D-48CE-4EDD-BC71-5E4A44DDCE8B"),
                UserName = "yayirgul@gmail.com",
                NormalizedUserName = "YAYIRGUL@GMAIL.COM",
                Email = "yayirgul@gmail.com",
                NormalizedEmail = "YAYIRGUL@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "+905558008040",
                PhoneNumberConfirmed = true,
                Firstname = "Yunus",
                Lastname = "AYIRGÜL",
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            admin.PasswordHash = CreatePasswordHash(admin, "1");

            builder.HasData(admin);
        }

        private string CreatePasswordHash(AppUser user, string password)
        {
            var pass = new PasswordHasher<AppUser>();
            return pass.HashPassword(user, password);
        }
    }
}
