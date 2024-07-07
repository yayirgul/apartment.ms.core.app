using ams.core.Entities;
using Microsoft.AspNetCore.Identity;

namespace ams.entity.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public Guid? AccountId { get; set; }
        public Guid? CreateUser { get; set; }
        public Guid? ModifiedUser { get; set; }
        public Guid? DeletedUser { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime? ModifiedTime { get; set; }
        public DateTime? DeletedTime { get; set; }
        public bool IsActive { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
    }
}
