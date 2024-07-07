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

    


        public Guid HousingId { get; set; }
        public Housing? Housing { get; set; } // 1 Borcun 1 konutu olur.


        public Guid OwnerId { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal? Amount { get; set; }

        public string? ExpenseCode { get; set; } // Expense Code Example = 07072024


        public bool Paid { get; set; }
    }
}
