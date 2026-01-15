namespace ams.data.Mappings
{
    using ams.entity.Entities;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AppUserMappings : IEntityTypeConfiguration<AppUser>
    {
        private const string DefaultPasswordHass = "AQAAAAIAAYagAAAAENQ3dkuS/u67bGlIXDv8nkCDq4gPlcPuSuuTaqgFr5x0RC4qNXhWefrLLUPYTCs95Q==";

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
                SecurityStamp = "9d63def9-ca57-4d94-8fdf-2292519cec84",
                ConcurrencyStamp = "3ce276c4-a032-4e27-8070-dcc52cf40dd7",
                IsActive = true,
                CreateTime = new DateTime(2026, 01, 01),
                PasswordHash = DefaultPasswordHass,
            };
            //admin.PasswordHash = CreatePasswordHash(admin, "1");

            var agent = new AppUser
            {
                Id = Guid.Parse("89DA7C75-8291-4BAF-9060-028A07393DDE"),
                AccountId = Guid.Parse("DB72E0E2-3201-414F-9753-190466E024F3"),
                UserName = "kadirkeles@hotmail.com",
                NormalizedUserName = "KADIRKELES@HOTMAIL.COM",
                Email = "kadirkeles@hotmail.com",
                NormalizedEmail = "KADIRKELES@HOTMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "+905558008050",
                PhoneNumberConfirmed = true,
                Firstname = "Kadir",
                Lastname = "Keleş",
                SecurityStamp = "be82a95e-81c8-4b07-89e6-eec384caf3ce",
                ConcurrencyStamp = "9d2171ca-c2c0-48af-8b71-b5dcc9c613a0",
                IsActive = true,
                CreateTime = new DateTime(2026, 01, 01),
                PasswordHash = DefaultPasswordHass,
            };
            //agent.PasswordHash = CreatePasswordHash(agent, "1");

            var user = new AppUser
            {
                Id = Guid.Parse("A35A610D-689F-4AB4-9324-CC227BFDBFBA"),
                AccountId = Guid.Parse("DB72E0E2-3201-414F-9753-190466E024F3"),
                UserName = "lokmanyilmaz@hotmail.com",
                NormalizedUserName = "LOKMANYILMAZ@HOTMAIL.COM",
                Email = "lokmanyilmaz@hotmail.com",
                NormalizedEmail = "LOKMANYILMAZ@HOTMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "+905558008060",
                PhoneNumberConfirmed = true,
                Firstname = "Lokman",
                Lastname = "Yılmaz",
                SecurityStamp = "deff56e3-b36c-461f-b4d3-fb88a1f13afa",
                ConcurrencyStamp = "023556ad-708e-4426-b761-0f997b740d07",
                IsActive = true,
                CreateTime = new DateTime(2026, 01, 01),
                PasswordHash = DefaultPasswordHass,
            };
            //user.PasswordHash = CreatePasswordHash(user, "1");

            builder.HasData(admin, agent, user);
        }

        // TODO : Bu yöntem artık geçerli değil
        //private string CreatePasswordHash(AppUser user, string password)
        //{
        //    var pass = new PasswordHasher<AppUser>();
        //    return pass.HashPassword(user, password);
        //}
    }
}
