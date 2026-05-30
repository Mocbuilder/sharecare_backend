namespace sharecare_backend.Models
{
    public class FixedTimeEntity : TimeTypeInterface
    {
        public int Id { get; set; }
        public TimeTypeEnum Type { get; set; }
        public DateTime Time { get; set; }
    }
}
