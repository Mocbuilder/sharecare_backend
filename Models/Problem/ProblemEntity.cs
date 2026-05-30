using sharecare_backend.Models.Location;
using sharecare_backend.Models.Payment;
using sharecare_backend.Models.Time;
using sharecare_backend.Models.User;

namespace sharecare_backend.Models.Problem
{
    public class ProblemEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProblemTypeEnum Type { get; set; }
        public TimeTypeInterface Time { get; set; }
        public bool IsLocationBound { get; set; }
        public LocationEntity Location { get; set; }
        public PaymentTypeInterface Payment { get; set; }
        public List<UserEntity> Providers { get; set; }
        public List<UserEntity> Searchers { get; set; }
    }
}
