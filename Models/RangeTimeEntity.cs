namespace sharecare_backend.Models
{
    public class RangeTimeEntity : TimeTypeInterface
    {
        public int Id { get; set; }
        public TimeTypeEnum Type { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
