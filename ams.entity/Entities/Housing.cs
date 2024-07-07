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


        public Guid ApartmentId { get; set; }
        public Apartment? Apartment { get; set; }


        public Guid? UserId { get; set; } // TODO : Konuta bağlı olacak kullanıcının Id'sini eşleştirmek için.
        public AppUser? User { get; set; }

        [StringLength(300)]
        public string? HousingName { get; set; }

        
        public ICollection<Debit>? Debits { get; set; } // TODO : 1 konutun 1'den çok borcu olabilir
    }
}
