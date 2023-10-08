using ams.core.Entities;

namespace ams.entity.Entities
{
    public class Debit : EntityBase // TODO : Borçlar
    {
        public Guid OwnerId { get; set; }
        public Guid AccountId { get; set; }

        public Guid HousingId { get; set; }
        public Housing Housings { get; set; } // 1 borcun 1 konutu olur

        public Guid ApartmentId { get; set; }
        public string? ExpenseCode { get; set; }
        public bool Paid { get; set; }
    }
}
