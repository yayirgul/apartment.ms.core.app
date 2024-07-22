namespace ams.entity.Entities
{
    using ams.core.Entities;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Housing: EntityBase // TODO: Konutlar
    {
        [ForeignKey(nameof(Account))]
        public Guid AccountId { get; set; }
        public Account? Account { get; set; }


        public Guid? ApartmentId { get; set; }
        public Apartment? Apartment { get; set; }


        //public Guid? HousingSafeId { get; set; }
        [ForeignKey("HousingSafe")]  
        public HousingSafe? HousingTheSafe { get; set; }



        public Guid? HousingUser { get; set; }
        [ForeignKey("HousingUser")] // Konut Sahibi
        public AppUser? HousingTheUser { get; set; }




        public Guid? CreateUser { get; set; }
        [ForeignKey("CreateUser")]
        public AppUser? CreateTheUser { get; set; }

        public Guid? ModifiedUser { get; set; }
        [ForeignKey("ModifiedUser")]
        public AppUser? ModifiedTheUser { get; set; }

        public Guid? DeleteUser { get; set; }
        [ForeignKey("DeleteUser")]
        public AppUser? DeleteTheUser { get; set; }

         



        [StringLength(300)]
        public string? HousingName { get; set; }

        
        public ICollection<Debit>? Debits { get; set; } // TODO : 1 konutun 1'den çok borcu olabilir
    }
}
