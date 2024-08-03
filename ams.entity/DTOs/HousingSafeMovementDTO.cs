namespace ams.entity.DTOs
{
    public class HousingSafeMovementDTO
    {
        public class Table
        {
            public string? HousingSafeAmount { get; set; }
            public string? MovementAmount { get; set; }
            public string? DebitAmount { get; set; }
            public int _Month { get; set; }
            public int _Year { get; set; }
            public string? CreateUser { get; set; }
            public string? ModifiedUser { get; set; }
            public DateTime CreateTime { get; set; }
            public string? _CreateTime { get; set; }
            public DateTime ModifiedTime { get; set; }
            public string? _ModifiedTime { get; set; }
            public string? MonthYear { get; set; }
        }
    }
}
