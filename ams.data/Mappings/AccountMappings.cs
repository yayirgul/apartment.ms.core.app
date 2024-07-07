namespace ams.data.Mappings
{
    using ams.entity.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AccountMappings : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasData(new Account
            {
                Id = Guid.Parse("DB72E0E2-3201-414F-9753-190466E024F3"),
                AccountName = "ABC A.Ş",
                Domain = "abc.com",
                IsTrial = true,
                IsActive = true,
            }
            );
        }
    }
}
