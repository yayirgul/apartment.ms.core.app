namespace ams.entity.DTOs
{
	public class ExpenseDTO
	{
		public class ListView
		{
			public Guid Id { get; set; }
			public Guid AccountId { get; set; }
			public Guid ApartmentId { get; set; }

			 
			public string? ExpenseName { get; set; }
			public string? ExpenseCode { get; set; }
            public string? ExpenseDate { get; set; }
            public string? _CreateTime { get; set; }


            public decimal? Amount { get; set; }
            public string? _Amount { get; set; }

            public int IsActive { get; set; }

            public int? Month { get; set; }
			public int? Year { get; set; }
			public bool IsFixed { get; set; }
		}
	}
}
