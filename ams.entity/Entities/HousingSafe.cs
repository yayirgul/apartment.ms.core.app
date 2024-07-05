namespace ams.entity.Entities
{
    using ams.core.Entities;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class HousingSafe : EntityBase // TODO: Konut Kasası
    {
        public Guid OwnerId { get; set; }

        [ForeignKey(nameof(Accounts))]
        public Guid AccountId { get; set; }
        public Account? Accounts { get; set; }

        [ForeignKey(nameof(Apartments))]
        public Guid ApartmentId { get; set; }
        public Apartment? Apartments { get; set; }


        [ForeignKey(nameof(Housing))]
        public Guid HousingId { get; set; }
        public Housing? Housing { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal? Amount { get; set; }
    }
}
