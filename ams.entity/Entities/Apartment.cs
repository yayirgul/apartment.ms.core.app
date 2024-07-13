namespace ams.entity.Entities
{
    using ams.core.Entities;
    using System.ComponentModel.DataAnnotations;

    public class Apartment : EntityBase
    {
        public Guid? AccountId { get; set; }
        public Account? Accounts { get; set; }

        [StringLength(300)]
        public string? ApartmentName { get; set; }

        public Guid? UserId { get; set; }
        public AppUser? User { get; set; }
    }
}
