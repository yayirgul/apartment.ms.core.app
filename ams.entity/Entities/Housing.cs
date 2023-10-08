﻿namespace ams.entity.Entities
{
    using ams.core.Entities;
    using System.ComponentModel.DataAnnotations;

    public class Housing: EntityBase // TODO: Konutlar
    {
        public Guid OwnerId { get; set; }
        public Guid AccountId { get; set; }
        public Account Accounts { get; set; }
        public Guid ApartmentId { get; set; }
        public Apartment Apartments { get; set; }
        [StringLength(300)]
        public string HousingName { get; set; }

        // TODO : 1 konutun 1'den çok borcu olabilir
        public ICollection<Debit> Debits { get; set; }
    }
}
