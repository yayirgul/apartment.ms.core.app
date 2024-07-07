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
                Id = Guid.Parse("6FA95F6E-2516-49E8-9AE6-7745E7743DBF"),
                AccountId = Guid.Parse("DB72E0E2-3201-414F-9753-190466E024F3"),
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

            var agent = new AppUser
            {
                Id = Guid.Parse("89DA7C75-8291-4BAF-9060-028A07393DDE"),
                AccountId = Guid.Parse("DB72E0E2-3201-414F-9753-190466E024F3"),
                UserName = "erdem@makronet.com",
                NormalizedUserName = "ERDEM@MAKRONET.COM",
                Email = "erdem@makronet.com",
                NormalizedEmail = "ERDEM@MAKRONET.COM",
                EmailConfirmed = true,
                PhoneNumber = "+905558008050",
                PhoneNumberConfirmed = true,
                Firstname = "Erdem",
                Lastname = "Tekin",
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            agent.PasswordHash = CreatePasswordHash(agent, "1");

            var user = new AppUser
            {
                Id = Guid.Parse("A35A610D-689F-4AB4-9324-CC227BFDBFBA"),
                AccountId = Guid.Parse("DB72E0E2-3201-414F-9753-190466E024F3"),
                UserName = "umut@makronet.com",
                NormalizedUserName = "UMUT@MAKRONET.COM",
                Email = "umut@makronet.com",
                NormalizedEmail = "UMUT@MAKRONET.COM",
                EmailConfirmed = true,
                PhoneNumber = "+905558008060",
                PhoneNumberConfirmed = true,
                Firstname = "Umut",
                Lastname = "Arslan",
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            user.PasswordHash = CreatePasswordHash(user, "1");

            builder.HasData(admin, agent, user);
        }

        private string CreatePasswordHash(AppUser user, string password)
        {
            var pass = new PasswordHasher<AppUser>();
            return pass.HashPassword(user, password);
        }
    }
}
