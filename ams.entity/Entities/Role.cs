namespace ams.entity.Entities
{
	using ams.core.Entities;
	using System.ComponentModel.DataAnnotations;

	public class Role : EntityBase
	{
		[StringLength(50)]
        public string? RoleType { get; set; }
    }
}
