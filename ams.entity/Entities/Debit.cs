﻿namespace ams.entity.Entities
{
    using ams.core.Entities;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Debit : EntityBase // TODO : Borçlar
    {
        public Guid OwnerId { get; set; }

        [ForeignKey(nameof(Account))]
        public Guid AccountId { get; set; }

        [ForeignKey(nameof(Housing))]
        public Guid HousingId { get; set; }
        public Housing? Housings { get; set; } // 1 Borcun 1 konutu olur.

        public Guid ApartmentId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Amount { get; set; }
        public string? ExpenseCode { get; set; }
        public bool Paid { get; set; }
    }
}
