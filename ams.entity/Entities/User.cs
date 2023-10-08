namespace ams.entity.Entities
{
    using ams.core.Entities;
    using System.ComponentModel.DataAnnotations;

    public class User : EntityBase
    {
        [StringLength(300)]
        public string? Username { get; set; }
        [StringLength(300)]
        public string? Password { get; set; }
        [StringLength(1000)]
        public string? Email { get; set; }
        [StringLength(300)]
        public string? Firstname { get; set; }
        [StringLength(300)]
        public string? Surname { get; set; }
    }
}
