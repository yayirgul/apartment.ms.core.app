namespace ams.entity.Entities
{
    using ams.core.Entities;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class HousingSafe : EntityBase // TODO: Konut Kasası
    {
        [ForeignKey(nameof(Account))]
        public Guid AccountId { get; set; }
        public Account? Account { get; set; }


        public Guid ApartmentId { get; set; }
        public Apartment? Apartment { get; set; }


        public Guid HousingId { get; set; }
        public Housing? Housing { get; set; }


        public Guid? UserId { get; set; }
        public AppUser? User { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Amount { get; set; }
    }
}
