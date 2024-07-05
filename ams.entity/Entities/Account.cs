namespace ams.entity.Entities
{
    using ams.core.Entities;
    using System.ComponentModel.DataAnnotations;

    public class Account : EntityBase
    {
        [StringLength(300)]
        public string? AccountName { get; set; }
        public string? Domain { get; set; }
        public bool IsTrial { get; set; }
        public DateTime? TrialEndDate { get; set; }
        public bool IsTestAccount { get; set; }
        public ICollection<Apartment> Apartments { get; set; } = null!;
        public ICollection<Housing> Housings { get; set; } = null!;
    }
}
