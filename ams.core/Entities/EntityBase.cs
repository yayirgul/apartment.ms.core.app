namespace ams.core.Entities
{
    public abstract class EntityBase : IEntityBase
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public virtual string? CreateBy { get; set; }
        public virtual string? ModifielBy { get; set; }
        public virtual string? DeletedBy { get; set; }
        public virtual DateTime CreateTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; }
        public virtual DateTime DeletedTime { get; set; }
        public virtual bool IsDeleted { get; set; } = false;
    }
}
