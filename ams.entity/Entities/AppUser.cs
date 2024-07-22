namespace ams.entity.Entities
{
    using ams.core.Entities;
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class AppUser : IdentityUser<Guid>, IEntityBase
    {
        public Guid? AccountId { get; set; }

        //[StringLength(300)]
        //public string? CreateThrUser { get; set; }
        //[StringLength(300)]
        //public string? ModifiedTheUser { get; set; }
        //[StringLength(300)]
        //public string? DeleteTheUser { get; set; }




        public Guid? CreateUser { get; set; }
        [ForeignKey("CreateUser")]
        public AppUser? CreateTheUser { get; set; }

        public Guid? ModifiedUser { get; set; }
        [ForeignKey("ModifiedUser")]
        public AppUser? ModifiedTheUser { get; set; }

        public Guid? DeleteUser { get; set; }
        [ForeignKey("DeleteUser")]
        public AppUser? DeleteTheUser { get; set; }




        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime? ModifiedTime { get; set; }
        public DateTime? DeletedTime { get; set; }
        public bool IsActive { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
    }
}
