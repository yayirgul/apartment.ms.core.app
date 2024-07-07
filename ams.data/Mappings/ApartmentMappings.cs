namespace ams.data.Mappings
{
    using ams.entity.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ApartmentMappings : IEntityTypeConfiguration<Apartment>
    {
        public void Configure(EntityTypeBuilder<Apartment> builder)
        {
            builder.HasData(new Apartment
            {
                Id = Guid.Parse("D4033EEF-BA92-4A1F-9ECB-1EEE6996214A"),
                AccountId = Guid.Parse("DB72E0E2-3201-414F-9753-190466E024F3"),
                ApartmentName = "Huzur APT",
                IsActive = true,
            });
        }
    }
}
