namespace sharecare_backend.Models
{
    public interface ProblemTypeInterface
    {
        public int Id { get; }
        public ProblemTypeEnum Type { get; }
        public string Name { get; }
        public string Description { get; }
        public LocationEntity Location { get; }
        public TimeTypeInterface Time { get; }
    }
}
