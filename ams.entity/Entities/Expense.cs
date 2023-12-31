﻿namespace ams.entity.Entities
{
    using ams.core.Entities;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Expense : EntityBase // TODO : Giderler
    {
        public Guid OwnerId { get; set; }
        public Guid AccountId { get; set; }
        public Account Accounts { get; set; }
        public Guid ApartmentId { get; set; }
        public Apartment Apartments { get; set; }
        [StringLength(300)]
        public string ExpenseName { get; set; }
        public string ExpenseCode { get; set; }
        public decimal? Amount { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
    }
}
