namespace ams.data.Mappings
{
    using ams.entity.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class HousingSafeMappings : IEntityTypeConfiguration<HousingSafe>
    {
        public void Configure(EntityTypeBuilder<HousingSafe> builder)
        {
            builder.HasData(new HousingSafe
            {
                Id = Guid.Parse("666776F7-518B-4805-A726-EBA238E03FC4"),
                AccountId = Guid.Parse("DB72E0E2-3201-414F-9753-190466E024F3"),
                ApartmentId = Guid.Parse("D4033EEF-BA92-4A1F-9ECB-1EEE6996214A"),
                HousingId = Guid.Parse("709A770B-66C6-4ADC-BD19-6438117BF646"),
                Amount = 100,
                IsActive = true,
            });
        }
    }
}
