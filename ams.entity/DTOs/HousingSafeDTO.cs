namespace ams.entity.DTOs
{
    public class HousingSafeDTO
    {
        public class Edit
        {
            public Guid HousingId { get; set; }
            public string? Amount { get; set; }
            public Guid ModifiedUser { get; set; }
            public DateTime ModifiedTime { get; set; }
        }

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


            public Guid ApartmentId { get; set; }
            public string? ApartmentName { get; set; }
            public string? HousingName { get; set; }
            public int? HousingNo { get; set; }
            public DateTime CreateTime { get; set; }
            public string? _CreateTime { get; set; }
            public string? _ModifiedTime { get; set; }
            public string? CreateUser { get; set; }
            public string? ModifiedUser { get; set; }
            public string? HousingUser { get; set; }
      
            public int IsActive { get; set; }
        }
    }
}
