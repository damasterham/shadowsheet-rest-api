using System.ComponentModel.DataAnnotations;

namespace ShadowAPI.Models
{
    public class Alias : BaseEntity
    { 
        public string StreetName { get; set; }
        public bool IsPrimary { get; set; }
    }
}