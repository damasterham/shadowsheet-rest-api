using System.ComponentModel.DataAnnotations;

namespace ShadowAPI.Models
{
    public class Alias : NamedEntity
    {
        //public string Street { get; set; } // Just made it a named entity so inherits Name property
        public bool IsPrimary { get; set; }
    }
}