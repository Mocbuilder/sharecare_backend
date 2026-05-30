namespace sharecare_backend.Models
{
    public class RProblemEntity : ProblemTypeInterface
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProblemTypeEnum Type { get; set; }
        public TimeTypeInterface Time { get; set; }
        public LocationEntity Location { get; set; }
        //Gebühr/Gegenwert
    }
}
