using sharecare_backend.Models.Location;
using sharecare_backend.Models.Payment;
using sharecare_backend.Models.Time;
using sharecare_backend.Models.User;

namespace sharecare_backend.Models.Problem
{
    public class ProblemDBEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TypeJson { get; set; }
        public string TimeJson { get; set; }
        public bool IsLocationBound { get; set; }
        public LocationEntity Location { get; set; }
        public string PaymentJson { get; set; }
        public List<int> ProvidersId { get; set; }
        public List<int> SearchersId { get; set; }

        public ProblemEntity ToNormalProblem()
        {
            //convert logic
            return null;
        }
    }
}
