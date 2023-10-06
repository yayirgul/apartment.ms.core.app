namespace ams.entity.Entities
{
    using ams.core.Entities;

    public class Account : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Apartment> Apartments { get; set; }
        public ICollection<Housing> Housings { get; set; }
    }
}
