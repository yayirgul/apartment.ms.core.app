namespace ams.entity.DTOs
{
	public class DashboardDTO
	{
		public class Indicator
        {
            public string Unpaid { get; set; } = null!;
            public int HousingPaid { get; set; }
            public int HousingUnpaid { get; set; }
        }

		public class Expense
		{
            public decimal Amount { get; set; }
            public string? _Amount { get; set; }
        }
	}
}
