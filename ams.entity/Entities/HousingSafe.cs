namespace ams.entity.Entities
{
    using ams.core.Entities;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class HousingSafe : EntityBase
    {
        [ForeignKey(nameof(Account))]
        public Guid AccountId { get; set; }
        public Account? Account { get; set; }

        public Guid ApartmentId { get; set; }
        public Apartment? Apartment { get; set; }

        public Guid? HousingId { get; set; }
        public Housing? Housing { get; set; }

        public Guid? HousingSafeUser { get; set; }
        [ForeignKey("HousingSafeUser")] // Konut kasa sahibi
        public AppUser? HousingSafeTheUser { get; set; }

        public Guid? CreateUser { get; set; }
        [ForeignKey("CreateUser")]
        public AppUser? CreateTheUser { get; set; }
        public Guid? ModifiedUser { get; set; }
        [ForeignKey("ModifiedUser")]
        public AppUser? ModifiedTheUser { get; set; }
        public Guid? DeleteUser { get; set; }
        [ForeignKey("DeleteUser")]

        public AppUser? DeleteTheUser { get; set; }
        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }
        public ICollection<HousingSafeMovement>? HousingSafeMovements { get; set; } // Bir "KASA'ya" ait birden çok "KASA HAREKETLERİ" olabilir.
    }
}
