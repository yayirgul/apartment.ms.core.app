namespace ams.entity.Entities
{
    using ams.core.Entities;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Apartment : EntityBase
    {
        public Guid? AccountId { get; set; }
        public Account? Accounts { get; set; }

        [StringLength(300)]
        public string? ApartmentName { get; set; }

        //public Guid? UserId { get; set; }
        //public AppUser? User { get; set; }

        public Guid? CreateUser { get; set; }
        [ForeignKey("CreateUser")] 
        public AppUser? CreateTheUser { get; set; }

        public Guid? ModifiedUser { get; set; }
        [ForeignKey("ModifiedUser")]  
        public AppUser? ModifiedTheUser { get; set; }

        public Guid? DeleteUser { get; set; }
        [ForeignKey("DeleteUser")] 
        public AppUser? DeleteTheUser { get; set; }
    }
}
