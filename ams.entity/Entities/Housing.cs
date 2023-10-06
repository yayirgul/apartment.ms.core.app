namespace ams.entity.Entities
{
    using ams.core.Entities;

    public class Housing: EntityBase // TODO: Housing --> Konutlar
    {
        public Guid AccountId { get; set; }
        public Guid ApartmentId { get; set; }
        public string Name { get; set; } = string.Empty;
   
        public Account Accounts { get; set; }
    }
}
