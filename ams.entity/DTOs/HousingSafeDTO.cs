namespace ams.entity.DTOs
{
    public class HousingSafeDTO
    {
        public class Detail
        {
            public Guid Id { get; set; }
            public decimal? Amount { get; set; }
            public string? _Amount { get; set; }
        }

        public class Table
        {
            public Guid Id { get; set; }
            public decimal? Amount { get; set; }
            public string? _Amount { get; set; }
        }
    }
}
