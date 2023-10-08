namespace ams.core.Entities
{
    using System.ComponentModel.DataAnnotations;

    public abstract class EntityBase : IEntityBase
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid();
        [StringLength(300)]
        public virtual Guid? CreateUserId { get; set; }
        [StringLength(300)]
        public virtual Guid? ModifiedUserId { get; set; }
        [StringLength(300)]
        public virtual string? DeletedBy { get; set; }
        public virtual DateTime CreateTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; }
        public virtual DateTime DeletedTime { get; set; }
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsStatus { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual int? LanguageId { get; set; }
    }
}
