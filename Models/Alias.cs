using System.ComponentModel.DataAnnotations;

namespace ShadowAPI.Models
{
    public class Alias
    {
        [Key]
        public long ID { get; set; }
        public string StreetName { get; set; }
        public bool IsPrimary { get; set; }
    }
}