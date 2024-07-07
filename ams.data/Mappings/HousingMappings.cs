namespace ams.data.Mappings
{
    using ams.entity.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class HousingMappings : IEntityTypeConfiguration<Housing>
    {
        public void Configure(EntityTypeBuilder<Housing> builder)
        {
            builder.HasData(new Housing
            {
                Id = Guid.Parse("709A770B-66C6-4ADC-BD19-6438117BF646"),
                AccountId = Guid.Parse("DB72E0E2-3201-414F-9753-190466E024F3"),
                ApartmentId = Guid.Parse("D4033EEF-BA92-4A1F-9ECB-1EEE6996214A"),
                HousingName = "Daire 1",
                IsActive = true,
            });
        }
    }
}
