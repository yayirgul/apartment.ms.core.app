namespace ams.entity.DTOs
{
    public class HousingDTO
    {
        public class Add
        {
            public Guid Id { get; set; }
            public Guid AccountId { get; set; }
            public Guid? ApartmentId { get; set; }
            public Guid? CreateUser { get; set; }
            public Guid? ModifiedUser { get; set; }
            public Guid? DeleteUser { get; set; }
            public Guid? HousingUser { get; set; }
            public string? HousingName { get; set; }
        }

        public class Edit
        {
            public Guid Id { get; set; }
            public Guid? ApartmentId { get; set; }
            public Guid? CreateUser { get; set; }
            public Guid? ModifiedUser { get; set; }
            public Guid? DeleteUser { get; set; }
            public DateTime? ModifiedTime { get; set; }
            public Guid? HousingUser { get; set; }
            public string? HousingName { get; set; }
        }

        public class Detail
        {
            public Guid Id { get; set; }
            public Guid? ApartmentId { get; set; }
            public Guid? CreateUser { get; set; }
            public Guid? ModifiedUser { get; set; }
            public Guid? DeleteUser { get; set; }
            public DateTime? ModifiedTime { get; set; }
            public Guid? HousingUser { get; set; }
            public string? HousingName { get; set; }
        }

        public class List
        {
            public Guid Id { get; set; }
            public Guid AccountId { get; set; }
            public Guid? ApartmentId { get; set; }
            public string? _CreateTime { get; set; }
            public string? _ModifiedTime { get; set; }
            public string? HousingUser { get; set; }
            public string? CreateUser { get; set; } 
            public string? ModifiedUser { get; set; }
            public string? HousingName { get; set; }
            public int IsActive { get; set; }
            public decimal? Amount { get; set; }
            public string? _Amount { get; set; }
        }
    }
}
