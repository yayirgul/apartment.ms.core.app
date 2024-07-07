namespace ams.core.Entities
{
    public abstract class EntityBase : IEntityBase
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public virtual Guid? CreateUser { get; set; }
        public virtual Guid? ModifiedUser { get; set; }
        public virtual Guid? DeletedUser { get; set; }
        public virtual DateTime CreateTime { get; set; } = DateTime.Now;
        public virtual DateTime? ModifiedTime { get; set; }
        public virtual DateTime? DeletedTime { get; set; }
        public virtual bool? IsDeleted { get; set; } = false;
        public virtual string? IsStatus { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual int? LanguageId { get; set; }
    }
}
