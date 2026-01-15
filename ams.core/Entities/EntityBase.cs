namespace ams.core.Entities
{
    using System.ComponentModel.DataAnnotations;

    public abstract class EntityBase : IEntityBase
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime CreateTime { get; set; }
        public virtual DateTime? ModifiedTime { get; set; }
        public virtual DateTime? DeletedTime { get; set; }
        public virtual bool IsDeleted { get; set; } = false;

        [StringLength(80)]
        public virtual string? IsStatus { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual int? LanguageId { get; set; }
    }
}
