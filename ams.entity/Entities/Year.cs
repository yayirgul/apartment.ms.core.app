namespace ams.entity.Entities
{
    using ams.core.Entities;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Year : EntityBase
    {
        public Guid? CreateUser { get; set; }
        [ForeignKey("CreateUser")]
        public AppUser? CreateTheUser { get; set; }

        public Guid? ModifiedUser { get; set; }
        [ForeignKey("ModifiedUser")]
        public AppUser? ModifiedTheUser { get; set; }

        public Guid? DeleteUser { get; set; }
        [ForeignKey("DeleteUser")]
        public AppUser? DeleteTheUser { get; set; }

        public int YearTX { get; set; }
    }
}