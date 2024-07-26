namespace ams.entity.DTOs
{
    public class DebitDTO
    {
        public class Add
        {
            public Guid ApartmentId { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
        }
    }
}
