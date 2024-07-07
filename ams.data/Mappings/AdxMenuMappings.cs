namespace ams.data.Mappings
{
    using ams.entity.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AdxMenuMappings : IEntityTypeConfiguration<AdxMenu>
    {
        public void Configure(EntityTypeBuilder<AdxMenu> builder)
        {
            builder.HasData(new AdxMenu
            {
                Id = Guid.Parse("A2B3D904-401C-431F-9845-7FA2652D87FC"),
                ParentId = Guid.Empty,
                Title = "Pano",
                Urls = "/",
                IsActive = true,
            });
        }
    }
}
