namespace ams.entity.Entities
{
    using ams.core.Entities;

    public class Apartment : EntityBase
    {
        public string? Name { get; set; }
        public Guid? AccountId { get; set; }
        public Account Accounts { get; set; }
    }
}
