namespace ams.entity.Entities
{
	using ams.core.Entities;
	using System;
	using System.ComponentModel.DataAnnotations;

	public class AdxMenu : EntityBase
	{
        public Guid ParentId { get; set; }
		[StringLength(100)]
        public string? Title { get; set; }
		[StringLength(500)]
		public string? MenuUrl { get; set; }
		[StringLength(50)]
        public string? Icons { get; set; }
    }
}
