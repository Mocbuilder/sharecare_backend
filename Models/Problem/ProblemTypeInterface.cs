using sharecare_backend.Models.Location;
using sharecare_backend.Models.Time;

namespace sharecare_backend.Models.Problem
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
