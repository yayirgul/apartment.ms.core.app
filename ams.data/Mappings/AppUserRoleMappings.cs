namespace ams.data.Mappings
{
    using ams.entity.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AppUserRoleMappings : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(
                new AppUserRole
                {
                    RoleId = Guid.Parse("4271DD20-390A-46CE-B67D-59678A720270"),
                    UserId = Guid.Parse("6FA95F6E-2516-49E8-9AE6-7745E7743DBF"),
                },
                new AppUserRole
                {
                    RoleId = Guid.Parse("4438DFF4-28D6-46C1-90EB-F6B2A233D97E"),
                    UserId = Guid.Parse("89DA7C75-8291-4BAF-9060-028A07393DDE"),
                },
                new AppUserRole
                {
                    RoleId = Guid.Parse("051004F1-A383-4746-A722-3B051D12AAEA"),
                    UserId = Guid.Parse("A35A610D-689F-4AB4-9324-CC227BFDBFBA"),
                }
                );
        }
    }
}
