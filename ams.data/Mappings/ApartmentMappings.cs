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
            },
            new Apartment {
                Id = Guid.Parse("16F885FF-6897-4D08-AFA6-0640C40D2A05"),
                AccountId = Guid.Parse("DB72E0E2-3201-414F-9753-190466E024F3"),
                ApartmentName = "Sevinç APT",
                IsActive = true,
            },
            new Apartment
            {
                Id = Guid.Parse("D2977402-D13F-423F-BC0F-E639E4A610BB"),
                AccountId = Guid.Parse("DB72E0E2-3201-414F-9753-190466E024F3"),
                ApartmentName = "Güvenç APT",
                IsActive = true,
            });
        }
    }
}
