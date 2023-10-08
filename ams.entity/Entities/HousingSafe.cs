namespace ams.entity.Entities
{
    using ams.core.Entities;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class HousingSafe : EntityBase // TODO: Konut Kasası
    {
        public Guid OwnerId { get; set; }
        public Guid AccountId { get; set; }
        public Account Accounts { get; set; }
        public Guid ApartmentId { get; set; }
        public Apartment Apartments { get; set; }
        [StringLength(300)]
        public string HousingName { get; set; }
        public decimal? Amount { get; set; }
    }
}
