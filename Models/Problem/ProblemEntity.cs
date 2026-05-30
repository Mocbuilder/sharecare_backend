using sharecare_backend.Models.Location;
using sharecare_backend.Models.Time;

namespace sharecare_backend.Models.Problem
{
    public class ProblemEntity : ProblemTypeInterface
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProblemTypeEnum Type { get; set; }
        public TimeTypeInterface Time { get; set; }
        public bool IsLocationBound { get; set; }
        public LocationEntity Location { get; set; }
        //Gebühr/Gegenwert
    }
}
