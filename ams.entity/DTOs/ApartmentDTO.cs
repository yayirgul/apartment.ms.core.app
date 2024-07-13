namespace ams.entity.DTOs
{
    public class ApartmentDTO
    {
        public class ListView
        {
            //public Guid? AccountId { get; set; }
            //public Account? Accounts { get; set; }

            public Guid ApartmentId { get; set; }
            public string? ApartmentName { get; set; }
            public DateTime CreateTime { get; set; }
            public string? _CreateTime { get; set; }
            public string? CreateUser { get; set; }
            public int IsActive { get; set; }
        }
    }
}
