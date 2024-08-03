namespace ams.entity.Entities
{
    using ams.core.Entities;
    using System.ComponentModel.DataAnnotations.Schema;

    public class HousingSafeMovement : EntityBase
    {
        public Guid? AccountId { get; set; }
        public Account? Account { get; set; }

        public Guid? ApartmentId { get; set; }
        public Apartment? Apartment { get; set; }

        public Guid? HousingId { get; set; }
        public Housing? Housing { get; set; }



        public Guid? HousingSafeId { get; set; }
        public HousingSafe? HousingSafe { get; set; }



  

        [Column(TypeName = "money")]
        public decimal? MovementAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DebitAmount { get; set; }




        public int _Month { get; set; }
        public int _Year { get; set; }
         

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
