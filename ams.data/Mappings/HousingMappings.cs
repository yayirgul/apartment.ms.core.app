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
                ApartmentId = Guid.Parse("16f885ff-6897-4d08-afa6-0640c40d2a05"),
                CreateUser = Guid.Parse("6FA95F6E-2516-49E8-9AE6-7745E7743DBF"),
                HousingName = "Daire 1",
                IsActive = true,
            });
        }
    }
}
