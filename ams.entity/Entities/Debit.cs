namespace ams.entity.Entities
{
    using ams.core.Entities;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Debit : EntityBase // TODO : Borçlar
    {
        [ForeignKey(nameof(Account))]
        public Guid AccountId { get; set; }
        public Account? Account { get; set; }


        public Guid ApartmentId { get; set; }
        public Apartment? Apartment { get; set; }


        public Guid? HousingId { get; set; }
        [ForeignKey("HousingId")]
        public Housing? Housing { get; set; } // 1 Borcun 1 konutu olur.





        public Guid? CreateUser { get; set; }
        [ForeignKey("CreateUser")]
        public AppUser? CreateTheUser { get; set; }

        public Guid? ModifiedUser { get; set; }
        [ForeignKey("ModifiedUser")]
        public AppUser? ModifiedTheUser { get; set; }

        public Guid? DeleteUser { get; set; }
        [ForeignKey("DeleteUser")]
        public AppUser? DeleteTheUser { get; set; }




        public Guid? DebitUser { get; set; }
        [ForeignKey("DebitUser")] // Borç sahibi
        public AppUser? DebitTheUser { get; set; }


        public int _Month { get; set; }
        public int _Year { get; set; }


        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public string? ExpenseCode { get; set; } // Expense Code Example = 07072024

        public bool Paid { get; set; }
    }
}
