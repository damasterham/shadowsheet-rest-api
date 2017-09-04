using System.Collections.Generic;

namespace ShadowAPI.Models
{
    public class Campaign : NamedEntity
    {        
        public ICollection<User> Players { get; set; } // Get Player Runners through User class
    }
}