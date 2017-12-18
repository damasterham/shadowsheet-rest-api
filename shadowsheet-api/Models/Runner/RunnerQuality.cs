namespace ShadowAPI.Models
{
    public class RunnerQuality
    {
        public long RunnerID { get; set; }
        public Runner Runner { get; set; }
        public long QualityID { get; set; }
        public Quality Quality { get; set; }
        public int? Rank { get; set; }
    }
}