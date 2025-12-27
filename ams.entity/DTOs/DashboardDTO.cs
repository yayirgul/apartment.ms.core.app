namespace ams.entity.DTOs
{
	public class DashboardDTO
	{
		public class Indicator
        {
            public string _Unpaid { get; set; } = null!;
            public decimal Unpaid { get; set; }
            public int HousingPaid { get; set; }
            public int HousingUnpaid { get; set; }
            public string Expense { get; set; } = null!;
            public string ExpenseFixed { get; set; } = null!;
        }

		public class Expense
		{
            public decimal Amount { get; set; }
            public string? _Amount { get; set; }
            public decimal ExpenseFixed { get; set; }
        }
	}
}
