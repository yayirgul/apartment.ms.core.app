namespace ams.entity.DTOs
{
    public class ApartmentDTO
    {
        public class Add
        {
            public Guid? Id { get; set; }
            public Guid? AccountId { get; set; }
            public string? ApartmentName { get; set; }
            public Guid? CreateUser { get; set; }
        }

        public class Edit
        {
            public Guid? Id { get; set; }
            public Guid? AccountId { get; set; }
            public string? ApartmentName { get; set; }
            public Guid? ModifiedUser { get; set; }
            public DateTime? ModifiedTime { get; set; }
        }

        public class Detail
        {
            public Guid Id { get; set; }
            public string? _CreateTime { get; set; }
            public string? _ModifiedTime { get; set; }
            public string? ApartmentName { get; set; }
        }

        public class ComboListView
        {
            public Guid Id { get; set; }
            public string? ApartmentName { get; set; }
        }

        public class Table
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
